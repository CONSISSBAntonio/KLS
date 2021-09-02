using KLS_API.Context;
using KLS_API.Models.Clients;
using Microsoft.AspNetCore.Mvc;
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
                             select new
                             {
                                 folio = viajes.Folio,
                                 origen = estadoorigen.nombre,
                                 destino = estadodestino.nombre,
                                 fechallegada = "",
                                 fechallegada_ = "",
                                 estatus = viajes.Substatus.Name,
                                 estatusId = viajes.Substatus.StatusId,
                                 idviaje = viajes.Id,
                                 cliente = cliente.NombreComercial
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

    }
}
