using KLS_API.Context;
using KLS_API.Models.Clients;
using KLS_API.Models.Monitoring;
using KLS_API.Models.Travel;
using KLS_API.Models.Travel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Monitoring
{
    [Route("Monitoring")]
    public class MonitoringController : Controller
    {
        private readonly AppDbContext context;

        public MonitoringController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult>Get()
        {
            try
            {
                //IQueryable<object> queryable = null;
                //queryable = (from viajes in context.Sections
                //             join cliente in context.Clientes on viajes.ClientesId equals cliente.id
                //             join origen in context.Cl_Has_Origen on viajes.Cl_Has_OrigenId equals origen.Id
                //             join estadoorigen in context.Cat_Estado on origen.Id_Estado equals estadoorigen.id
                //             join destino in context.Cl_Has_Destinos on viajes.Cl_Has_DestinosId equals destino.Id
                //             join estadodestino in context.Cat_Estado on destino.Id equals estadodestino.id
                //             join ruta in context.Ruta on viajes.RutaId equals ruta.id
                //             join substatus in context.Substatuses on viajes.SubstatusId equals substatus.Id
                //             join status in context.Statuses on substatus.StatusId equals status.Id
                //             select new
                //             {
                //                 folio = viajes.Folio,
                //                 origen = estadoorigen.nombre,
                //                 destino = estadodestino.nombre,
                //                 fechallegada = "",
                //                 fechallegada_ = "",
                //                 estatus = status.Name,//me falta el nombre
                //                 estatusId = status.Id,
                //                 substatus = substatus.Name,
                //                 subestatusId = substatus.Id,
                //                 idviaje = viajes.Id,
                //                 cliente = cliente.NombreComercial,
                //                 fechasalida = viajes.FechaSalida,
                //                 tiemporuta = ruta.tiemporuta,
                //                 idcliente = cliente.id,
                //                 idruta = ruta.id,
                //                 frecuenciaValidacion = ruta.frecvalidacion
                //             }).ToList().AsQueryable();
                

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
                    //Id = x.Id,
                    //MainTravelId = x.TravelId,
                    //Folio = x.Folio,
                    //Cliente = x.Clients.NombreCorto ?? "-",
                    //Origen = !x.IsEmpty ? string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre, "-", context.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Ciudad).nombre) : string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadoorigen).nombre, "-", context.Cat_Ciudad.SingleOrDefault(y => y.id == x.Ruta.id_ciudadorigen).nombre),
                    //Destino = !x.IsEmpty ? string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre, "-", context.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Ciudad).nombre) : string.Concat(context.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadodestino).nombre, "-", context.Cat_Ciudad.SingleOrDefault(y => y.id == x.Ruta.id_ciudaddestino).nombre),
                    //FechaSalida = x.FechaSalida.ToString("dd/MM/yyyy. hh:mm tt"),
                    //FechaLlegada = x.FechaLlegada.ToString("dd/MM/yyyy. hh:mm tt"),
                    //Estatus = x.Substatus.Name
                return Ok(sections);
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


        [Route("getClient")]
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

        [HttpGet]
        [Route("getStatus")]
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
        
        [HttpGet]
        [Route("getSubStatus")]
        public ActionResult getSubStatus()
        {
            try
            {
                var cnts = context.Substatuses.ToList();
                return Ok(cnts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("setCommentario")]
        public ActionResult Post([FromBody] SectionComment secciones)
        {
            try
            {
                context.SectionComments.Add(secciones);
                context.SaveChanges();
                Section dato_ = new Section { Id = secciones.SectionId,SubstatusId = secciones.SubstatusId};
                context.Attach(dato_);
                context.Entry(dato_).Property("SubstatusId").IsModified = true;
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getCheckpoints/{id}")]
        public ActionResult getCheckpoints(int id)
        {
            try
            {
                var checkpoint = context.Ruta_Has_Checkpoint.Where(f => f.RutaId == id).ToList();
                return Ok(checkpoint);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("getSCheckpoints/{id}")]
        public ActionResult getSCheckpoints(int id)
        {
            try
            {
                var checkpoint = context.Section_Has_Checkpoint.Where(f => f.idSection == id).ToList();
                return Ok(checkpoint);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("setSCheckpoints")]
        public ActionResult setSCheckpoints([FromBody] Section_Has_Checkpoint secciones)
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

    }
}
