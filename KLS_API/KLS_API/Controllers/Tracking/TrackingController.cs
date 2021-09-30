using KLS_API.Context;
using KLS_API.Models;
using KLS_API.Models.Clients;
using KLS_API.Models.DT;
using KLS_API.Models.Travel;
using KLS_API.Models.Travel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Tracking
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TrackingController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TrackingController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        #region Customer
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                ICollection<Clientes> clientes = await _dbContext.Clientes.Where(x => x.Estatus == 1).OrderBy(x => x.NombreCorto).ToListAsync();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Statuses
        [HttpGet]
        public async Task<IActionResult> GetStatuses()
        {
            try
            {
                ICollection<Status> statuses = await _dbContext.Statuses.Where(x => x.Active).ToListAsync();
                return Ok(statuses);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{StatusId}")]
        public async Task<IActionResult> GetSubstatuses(int StatusId)
        {
            try
            {
                ICollection<Substatus> substatuses = await _dbContext.Substatuses.Where(x => x.StatusId == StatusId && x.Active).ToListAsync();
                return Ok(substatuses);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Counter
        [HttpGet]
        public async Task<IActionResult> TrackingCounter()
        {
            try
            {
                var counter = new
                {
                    //Todos = await _dbContext.Sections.Include(x => x.Substatus).ThenInclude(x => x.Status).Where(x => x.Active && x.Substatus.StatusId == 3).CountAsync(),
                    Todos = await _dbContext.Sections.Where(x => x.Active).CountAsync(),
                    Confirmados = await _dbContext.Sections.Include(x => x.Substatus).Where(x => x.Substatus.StatusId == 2 && x.Active).CountAsync(),
                    EnTransito = await _dbContext.Sections.Include(x => x.Substatus).Where(x => x.Substatus.StatusId == 3 && x.Active).CountAsync(),
                    Demorados = await _dbContext.Sections.Where(x => x.SubstatusId == 9 && x.Active).CountAsync()
                };

                return Ok(counter);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region AddSectionComment
        [HttpPost]
        public async Task<IActionResult> AddSectionComment(SectionCommentDTO sectionComment)
        {
            try
            {
                Section section = await _dbContext.Sections.FindAsync(sectionComment.SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                section.StatusUpdatedAt = section.SubstatusId == sectionComment.SubstatusId ? section.StatusUpdatedAt : DateTime.Now;
                section.SubstatusId = sectionComment.SubstatusId;
                section.GrupoMonitor = sectionComment.GrupoMonitor ?? section.GrupoMonitor;
                section.UpdatedBy = sectionComment.CreatedBy;
                section.TimeUpdated = DateTime.Now;

                if (!string.IsNullOrEmpty(sectionComment.Comment?.Trim()))
                {
                    SectionComment newSectionComment = new SectionComment
                    {
                        SectionId = sectionComment.SectionId,
                        SubstatusId = sectionComment.SubstatusId,
                        Comment = sectionComment.Comment,
                        CreatedBy = sectionComment.CreatedBy
                    };

                    await _dbContext.SectionComments.AddAsync(newSectionComment);
                    return Ok(newSectionComment);
                }
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEvidence(Evidence evidence)
        {
            try
            {
                await _dbContext.Evidences.AddAsync(evidence);
                await _dbContext.SaveChangesAsync();
                return Ok(evidence);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region DT
        [HttpGet]
        public async Task<IActionResult> Tracking()
        {
            try
            {
                ICollection<Section> sections = await _dbContext.Sections.Include(x => x.Ruta).Where(x => x.Active).ToListAsync();
                return Ok(sections);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DataTable(DTParams dtParams)
        {
            try
            {
                IEnumerable<TrackingDT> sections = await _dbContext.Sections.Include(x => x.Ruta).Include(x => x.Substatus).ThenInclude(x => x.Status).Where(x => x.Active).Select(x => new TrackingDT
                {
                    TravelId = x.TravelId,
                    SectionId = x.Id,
                    RutaId = x.RutaId,
                    CustomerId = x.ClientesId ?? 0,
                    StatusId = x.Substatus.StatusId,
                    SubstatusId = x.SubstatusId,
                    Folio = x.Folio,
                    Cliente = x.Clients.NombreCorto ?? "-",
                    Origen = _dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadoorigen).nombre,
                    Destino = _dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadodestino).nombre,
                    FechaSalida = x.FechaSalida.ToString("dd/MM/yyyy hh:mm tt"),
                    FechaLlegada = x.FechaLlegada.ToString("dd/MM/yyyy hh:mm tt"),
                    SiguienteContacto = x.StatusUpdatedAt.AddHours(x.Ruta.frecvalidacion),
                    ETA = string.Concat(x.Ruta.tiemporuta, " HRS"),
                    GrupoMonitor = x.GrupoMonitor,
                    Status = string.Concat(x.Substatus.Status.Name, " - ", x.Substatus.Name),
                    Checkpoint = string.Concat(x.Ruta.frecvalidacion, " HRS"),
                    HasCheckpoints = _dbContext.Ruta_Has_Checkpoint.Any(y => y.RutaId == x.RutaId),
                    ExitDate = x.FechaSalida
                }).ToListAsync();

                int total = sections.Count();

                if (!string.IsNullOrEmpty(dtParams.search.value[0]))
                {
                    string keyword = dtParams.search.value[0].ToLower();

                    sections = sections.Where(x => x.Folio.ToLower().Contains(keyword) ||
                    x.Cliente.ToLower().Contains(keyword) ||
                    x.Origen.ToLower().Contains(keyword) ||
                    x.Destino.ToLower().Contains(keyword) ||
                    x.FechaSalida.ToLower().Contains(keyword) ||
                    x.FechaLlegada.ToLower().Contains(keyword) ||
                    x.SiguienteContacto.ToString().ToLower().Contains(keyword) ||
                    x.ETA.ToLower().Contains(keyword) ||
                    x.GrupoMonitor.ToLower().Contains(keyword) ||
                    x.Status.ToLower().Contains(keyword));
                }

                if (dtParams.Filter.Any())
                {
                    sections = sections.Where(x => dtParams.Filter.Contains(x.CustomerId));
                }

                if (dtParams.CustomSearch && string.IsNullOrEmpty(dtParams.CSType))
                {
                    sections = sections.Where(x => x.SubstatusId == dtParams.SubstatusId);
                }

                if (dtParams.CustomSearch && !string.IsNullOrEmpty(dtParams.CSType))
                {
                    switch (dtParams.CSType)
                    {
                        case "status":
                            sections = sections.Where(x => x.StatusId == dtParams.SubstatusId);
                            break;
                        case "substatus":
                            sections = sections.Where(x => x.SubstatusId == dtParams.SubstatusId);
                            break;
                        default:
                            break;
                    }
                }

                long totalFiltered = sections.Count();

                int columnId = dtParams.order[0].column[0];

                Func<TrackingDT, string> orderFunction = (x => columnId == 0 ? x.Folio :
                columnId == 1 ? x.Cliente :
                columnId == 2 ? x.Origen :
                columnId == 3 ? x.Destino :
                columnId == 4 ? x.FechaSalida :
                columnId == 5 ? x.FechaLlegada :
                x.Status);

                sections = dtParams.order[0].dir[0] == "asc" ? sections.OrderBy(orderFunction) : sections.OrderByDescending(orderFunction);

                sections = sections.Skip(dtParams.start).Take(dtParams.length);

                List<TrackingDT> data = sections.ToList();

                return Json(new
                {
                    aaData = data.OrderBy(x => x.SiguienteContacto),
                    dtParams.draw,
                    iTotalRecords = total,
                    iTotalDisplayRecords = totalFiltered
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Events
        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetDetails(int SectionId)
        {
            try
            {
                SectionDetailDTO section = await _dbContext.Sections
                    .Include(x => x.Ruta)
                    .Include(x => x.Services)
                    .Include(x => x.Services)
                    .ThenInclude(x => x.Transportista)
                    .Include(x => x.Services)
                    .ThenInclude(x => x.Tr_Has_Operadores)
                    .Include(x => x.Cl_Has_Origen)
                    .Include(x => x.Cl_Has_Destinos)
                    .Include(x => x.Substatus)
                    .ThenInclude(x => x.Status)
                    .Where(x => x.Id == SectionId)
                    .Select(x => new SectionDetailDTO
                    {
                        StatusId = x.Substatus.Status.Id,
                        SubstatusId = x.SubstatusId,
                        Folio = x.Folio,
                        Transportista = x.Services.FirstOrDefault().Transportista.RazonSocial,
                        Conductor = x.Services.FirstOrDefault().Tr_Has_Operadores.nombre,
                        Origen = x.IsEmpty ? string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Ruta.id_estadoorigen).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Ruta.id_ciudadorigen).nombre) : x.Cl_Has_Origen.Direccion,
                        Destino = x.IsEmpty ? string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Ruta.id_estadodestino).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Ruta.id_ciudaddestino).nombre) : x.Cl_Has_Destinos.Direccion,
                        Telefono = x.Services.FirstOrDefault().Tr_Has_Operadores.NoTelefono,
                        TipoDeUnidad = _dbContext.Travels.Include(x => x.TravelService).SingleOrDefault(y => y.Id == x.TravelId).TravelService.Name
                    }).SingleOrDefaultAsync();

                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCheckpoints(int RouteId, int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections
                    .Include(x => x.Ruta)
                    .ThenInclude(x => x.Ruta_Has_Checkpoints)
                    .SingleOrDefaultAsync(x => x.Id == SectionId);

                if (section is null)
                {
                    return NotFound();
                }

                ICollection<CheckpointsDTO> checkpoints = await _dbContext.Ruta_Has_Checkpoint.Where(x => x.RutaId == RouteId).Select(x => new CheckpointsDTO
                {
                    Checkpoint = x.nombre,
                    HoraOriginal = section.FechaSalida.ToString("dd/MM/yyyy hh:mm tt"),
                    HoraEsperada = section.FechaSalida.AddHours(x.tiempo).ToString("dd/MM/yyyy hh:mm tt"),
                    HoraReal = "-",
                    Usuario = "-"
                }).ToListAsync();
                return Ok(checkpoints);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetGrupoMonitor()
        {
            try
            {
                var grupomonitor = await _dbContext.Sections.Where(x => x.Active).Select(x => x.GrupoMonitor).GroupBy(x => x).OrderBy(x => x.Count()).Select(x => x.Key).ToArrayAsync();
                Array.Sort(grupomonitor);
                return Ok(grupomonitor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> GetSectionStatus(int SectionId)
        //{
        //    try
        //    {
        //        var section = 
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        #endregion
    }
}
