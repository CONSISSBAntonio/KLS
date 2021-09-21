using KLS_API.Context;
using KLS_API.Models.Clients;
using KLS_API.Models.Monitoring;
using KLS_API.Models.Travel;
using KLS_API.Models.Travel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Monitoring
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MonitoringController : Controller
    {
        private readonly AppDbContext context;
        public MonitoringController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> DataTableMonitoring(DTParams dtParams)
        {
            try
            {
                IEnumerable<Monitoring> sections = await context.Sections.Where(x => x.Active).Select(x => new Monitoring
                {
                    folio = x.Folio,
                    origen = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre),
                    destino = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre),
                    fechallegada = "",
                    fechallegada_ = "",
                    estatus = x.Substatus.Status.Name,//me falta el nombre
                    estatusId = x.Substatus.Status.Id,
                    substatus = x.Substatus.Name,
                    subestatusId = x.Substatus.Id,
                    idviaje = x.Id,
                    cliente = x.Clients.NombreComercial ?? "-",
                    fechasalida = x.FechaSalida.ToString("yyyy-MM-dd hh:mm:ss"),
                    tiemporuta = x.Ruta.tiemporuta,
                    idcliente = x.Clients.id,
                    idruta = x.Ruta.id,
                    frecuenciaValidacion = x.Ruta.frecvalidacion
                }).ToListAsync();

                if (dtParams.searchmodel.ClientId != 0)
                {
                    sections = sections.Where(x => x.idcliente == dtParams.searchmodel.ClientId);
                }
                if (dtParams.searchmodel.estatusId != 0)
                {
                    sections = sections.Where(x => x.estatusId == dtParams.searchmodel.estatusId);
                }
                if (dtParams.searchmodel.subestatusId != 0)
                {
                    sections = sections.Where(x => x.subestatusId == dtParams.searchmodel.subestatusId);
                }

                int total = sections.Count();
                long totalFiltered = sections.Count();

                int columnId = dtParams.order[0].column[0];

                Func<Monitoring, string> orderFunction = (x => columnId == 0 ? x.folio :
                x.estatus);

                sections = sections.Skip(dtParams.start).Take(dtParams.length);
                List<Monitoring> data = sections.ToList();
                return Json(new
                {
                    aaData = data,
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
        public class Monitoring
        {
            public string folio { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public string fechallegada { get; set; }
            public string fechallegada_ { get; set; }
            public string estatus { get; set; }
            public int estatusId { get; set; } //Estatud
            public string substatus { get; set; }
            public int subestatusId { get; set; }
            public int idviaje { get; set; }
            public string cliente { get; set; }
            public string fechasalida { get; set; }
            public int tiemporuta { get; set; }
            public int idcliente { get; set; }
            public int idruta { get; set; }
            public int frecuenciaValidacion { get; set; }
        }
        public ActionResult getClient()
        {
            try
            {

                return Ok(context.Clientes.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public ActionResult getStatus()
        {
            try
            {
                var cnts = context.Statuses.ToList();
                return Ok(cnts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public ActionResult getSubStatus(int id = 0)
        {
            try
            {
                if (id != 0)
                {
                    var cnts = context.Substatuses.Where(x=>x.StatusId == id).ToList();
                    return Ok(cnts);
                }
                else {
                    var cnts = context.Substatuses.ToList();
                    return Ok(cnts);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<ActionResult> Comment(int id) {
            try
            {
                Monitoring sections = await context.Sections.Where(x => x.Active & x.Id == id).Select(x => new Monitoring
                {
                    folio = x.Folio,
                    origen = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre),
                    destino = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre),
                    fechallegada = "",
                    fechallegada_ = "",
                    estatus = x.Substatus.Status.Name,//me falta el nombre
                    estatusId = x.Substatus.Status.Id,
                    substatus = x.Substatus.Name,
                    subestatusId = x.Substatus.Id,
                    idviaje = x.Id,
                    cliente = x.Clients.NombreComercial ?? "-",
                    fechasalida = x.FechaSalida.ToString("yyyy-MM-dd hh:mm:ss"),
                    tiemporuta = x.Ruta.tiemporuta,
                    idcliente = x.Clients.id,
                    idruta = x.Ruta.id,
                    frecuenciaValidacion = x.Ruta.frecvalidacion
                }).FirstOrDefaultAsync();
                               
                return Ok(sections);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult SetCommentario([FromBody] SectionComment secciones)
        {
            try
            {
                context.SectionComments.Add(secciones);
                context.SaveChanges();

                Section dato_ = new Section { Id = secciones.SectionId, SubstatusId = secciones.SubstatusId };
                context.Attach(dato_);
                context.Entry(dato_).Property("SubstatusId").IsModified = true;
                context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        public async Task<IActionResult> Checkpoint(int idviaje,int idruta) {
            var checkpointruta = context.Ruta_Has_Checkpoint.Where(f => f.RutaId == idruta).ToList();
            var checkpointseccion = context.Section_Has_Checkpoint.Where(f => f.idSection == idviaje).ToList();
            return Json(new
            {
                ruta_Has_Checkpoint = checkpointruta,
                section_has_checkpoint = checkpointseccion
            });
        }
        [HttpPost]
        public async Task<IActionResult> setSCheckpoints([FromBody] Section_Has_Checkpoint secciones)
        
        
        {
            try
            {
                context.Section_Has_Checkpoint.Add(secciones);
                context.SaveChanges();
                return Ok(secciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getConteo() {
            var q = from c in context.Sections
                    where c.Active == true
                    join substatus in context.Substatuses on c.SubstatusId equals substatus.Id
                    where substatus.Active == true
                    join status in context.Statuses on substatus.StatusId equals status.Id
                    where status.Active == true
                    group status by status.Id into g
                    select new { g.Key, Count = g.Count() };
            return Ok(q);
        }
        public async Task<IActionResult> downloadExcel() {
            try
            {
                IEnumerable<Monitoring> sections = await context.Sections.Where(x => x.Active).Select(x => new Monitoring
                {
                    folio = x.Folio,
                    origen = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre),
                    destino = string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre),
                    fechallegada = "",
                    fechallegada_ = "",
                    estatus = x.Substatus.Status.Name,//me falta el nombre
                    estatusId = x.Substatus.Status.Id,
                    substatus = x.Substatus.Name,
                    subestatusId = x.Substatus.Id,
                    idviaje = x.Id,
                    cliente = x.Clients.NombreComercial ?? "-",
                    fechasalida = x.FechaSalida.ToString("yyyy-MM-dd hh:mm:ss"),
                    tiemporuta = x.Ruta.tiemporuta,
                    idcliente = x.Clients.id,
                    idruta = x.Ruta.id,
                    frecuenciaValidacion = x.Ruta.frecvalidacion
                }).ToListAsync();

                return Ok(sections);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
