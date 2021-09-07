using KLS_API.Context;
using KLS_API.Models.Clients;
using KLS_API.Models.Monitoring;
using KLS_API.Models.Travel;
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

        public ActionResult Get()
        {
            try
            {
                IQueryable<object> queryable = null;
                queryable = (from viajes in context.Sections
                             join cliente in context.Clientes on viajes.ClientesId equals cliente.id
                             join origen in context.Cl_Has_Origen on viajes.Cl_Has_OrigenId equals origen.Id
                             join estadoorigen in context.Cat_Estado on origen.Id_Estado equals estadoorigen.id
                             join destino in context.Cl_Has_Destinos on viajes.Cl_Has_DestinosId equals destino.Id
                             join estadodestino in context.Cat_Estado on destino.Id equals estadodestino.id
                             join ruta in context.Ruta on viajes.RutaId equals ruta.id
                             join substatus in context.Substatuses on viajes.SubstatusId equals substatus.Id
                             join status in context.Statuses on substatus.StatusId equals status.Id
                             select new
                             {
                                 folio = viajes.Folio,
                                 origen = estadoorigen.nombre,
                                 destino = estadodestino.nombre,
                                 fechallegada = "",
                                 fechallegada_ = "",
                                 estatus = status.Name,//me falta el nombre
                                 estatusId = status.Id,
                                 substatus = substatus.Name,
                                 subestatusId = substatus.Id,
                                 idviaje = viajes.Id,
                                 cliente = cliente.NombreComercial,
                                 fechasalida = viajes.FechaSalida,
                                 tiemporuta = ruta.tiemporuta,
                                 idcliente = cliente.id,
                                 idruta = ruta.id,
                                 frecuenciaValidacion = ruta.frecvalidacion
                             }).ToList().AsQueryable();
                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
                var checkpoint = context.Cl_Has_Checkpoint.Where(f => f.Id_Ruta == id).ToList();
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
