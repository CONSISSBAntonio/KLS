using KLS_API.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using KLS_API.Models;
using Microsoft.EntityFrameworkCore;
using KLS_API.Models.Travel;
using KLS_API.Models.Clients;
using KLS_API.Models.Travel.DTO;
using KLS_API.Models.Carriers;

namespace KLS_API.Controllers.Travels
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TravelsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region SelectList
        [HttpGet]
        public async Task<IActionResult> GetTiposUnidades()
        {
            try
            {
                ICollection<Cat_Tipos_Unidades> cat_Tipos_Unidades = await _dbContext.Cat_Tipos_Unidades.Where(x => x.estatus == 1).ToListAsync();
                return Ok(cat_Tipos_Unidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                ICollection<Clientes> customers = await _dbContext.Clientes.Where(x => x.Estatus == 1).ToListAsync();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSectionType()
        {
            try
            {
                ICollection<SectionType> sectionTypes = await _dbContext.SectionTypes.Where(x => x.Active).ToListAsync();
                return Ok(sectionTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCarriers()
        {
            try
            {
                ICollection<Transportista> carriers = await _dbContext.Transportista.Where(x => x.Estatus == 1).ToListAsync();
                return Ok(carriers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        #endregion

        #region Travel
        [HttpGet("{TravelId}")]
        public async Task<IActionResult> GetTravel(int TravelId)
        {
            try
            {
                Travel travel = await _dbContext.Travels.Include(x => x.Sections).Where(x => x.Id == TravelId && x.Active).Select(x => new Travel
                {
                    Id = x.Id,
                    SubstatusId = x.SubstatusId,
                    Substatus = _dbContext.Substatuses.SingleOrDefault(z => z.Active && z.Id == x.SubstatusId),
                    Folio = x.Folio,
                    Cat_Tipos_UnidadesId = x.Cat_Tipos_UnidadesId,
                    Cat_Tipos_Unidades = _dbContext.Cat_Tipos_Unidades.SingleOrDefault(y => y.estatus == 1 && y.id == x.Cat_Tipos_UnidadesId),
                    Sections = _dbContext.Sections.Include(y => y.Clients).Include(y => y.Services).Where(y => y.TravelId == TravelId && x.Active).ToList(),
                    Ejecutivo = x.Ejecutivo,
                    GrupoMonitor = x.GrupoMonitor,
                    Active = x.Active,
                    CreatedBy = x.CreatedBy,
                    UpdatedBy = x.UpdatedBy,
                    TimeCreated = x.TimeCreated,
                    TimeUpdated = x.TimeUpdated
                }).SingleOrDefaultAsync();
                if (travel is null)
                {
                    return NotFound();
                }
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostTravel(Travel travel)
        {
            try
            {
                int status = _dbContext.Statuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                int substatus = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                int lastid = _dbContext.Travels.DefaultIfEmpty().Max(x => x == null ? 1 : x.Id);

                travel.Folio = string.Concat("V", DateTime.Now.ToString("yyMM"), lastid.ToString("D4"));
                travel.SubstatusId = substatus;

                await _dbContext.Travels.AddAsync(travel);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutTravel(Travel travel)
        {
            try
            {
                _dbContext.Entry(travel).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        #endregion

        #region Section
        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetSection(int SectionId)
        {
            try
            {

                Section section = await _dbContext.Sections.Include(x => x.Services).ThenInclude(x => x.Units).Where(x => x.Id == SectionId).FirstOrDefaultAsync();
                if (section is null)
                {
                    return NotFound();
                }
                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetCustomerOD(int CustomerId)
        {
            try
            {
                CustomerOD customerOD = new CustomerOD
                {
                    Origins = await _dbContext.Cl_Has_Origen.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).ToListAsync(),
                    Destinations = await _dbContext.Cl_Has_Destinos.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).ToListAsync()
                };
                return Ok(customerOD);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> PostSection(Section section)
        {
            try
            {
                if (section.TravelId == 0)
                {
                    return BadRequest();
                }

                int lastid = _dbContext.Sections.Where(x => x.TravelId == section.TravelId && x.Active).Count() + 1;

                section.Folio = string.Concat("V", DateTime.Now.ToString("yyMM"), section.TravelId.ToString("D4"), "-", lastid.ToString("D2"));
                section.SubstatusId = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                section.Cl_Has_OtrosId = _dbContext.Cl_Has_Otros.FirstOrDefault(x => x.Id_Cliente == section.ClientesId).Id;

                await _dbContext.Sections.AddAsync(section);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutSection(Section model)
        {
            try
            {
                model.SubstatusId = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                model.Cl_Has_OtrosId = _dbContext.Cl_Has_Otros.FirstOrDefault(x => x.Id_Cliente == model.ClientesId).Id;
                model.TimeUpdated = DateTime.Now;
                _dbContext.Entry(model).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        #endregion

        public class SearchRuta
        {
            public int Id { get; set; }
            public string OD { get; set; }
            public int OriginId { get; set; }
            public int DestinationId { get; set; }
        }

        [HttpPost]
        public IActionResult GetRoute([FromBody] SearchRuta search)
        {
            try
            {
                List<SearchRuta> routes = _dbContext.Ruta.Where(x => x.id_ciudadorigen == _dbContext.Cl_Has_Origen.Find(search.OriginId).Id_Ciudad && x.id_ciudaddestino == _dbContext.Cl_Has_Destinos.Find(search.DestinationId).Id_Ciudad).Select(x => new SearchRuta
                {
                    Id = x.id,
                    OD = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadoorigen).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudadorigen).nombre, " - ", _dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadodestino).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudaddestino).nombre)
                }).ToList();
                return Ok(routes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpGet("{Type}/{Id}")]
        public IActionResult GetAddress(string Type, int Id)
        {
            try
            {
                if (Id == 0)
                {
                    return NotFound();
                }

                string address = string.Empty;

                if (Type == "origin")
                {
                    address = _dbContext.Cl_Has_Origen.Find(Id).Direccion;
                    return Ok(address);
                }

                address = _dbContext.Cl_Has_Destinos.Find(Id).Direccion;
                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
