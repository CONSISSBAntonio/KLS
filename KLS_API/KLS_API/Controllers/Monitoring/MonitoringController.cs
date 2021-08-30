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
                queryable = (from viajes in context.Viajes
                             join cliente in context.Clientes on viajes.IdCliente equals cliente.id
                             join origen in context.Cl_Has_Origen on viajes.IdOrigen equals origen.Id
                             join estadoorigen in context.Cat_Estado on origen.Id_Estado equals estadoorigen.id
                             join destino in context.Cl_Has_Destinos on viajes.IdDestino equals destino.Id
                             join estadodestino in context.Cat_Estado on destino.Id equals estadodestino.id
                             select new
                             {
                                 folio = viajes.Folio,
                                 origen = estadoorigen.nombre,
                                 destino = estadodestino.nombre,
                                 fechallegada = "",
                                 fechallegada_ = "",
                                 estatus = viajes.SubEstatus,
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

        //[Route("/getClient")]
        //public ActionResult getClient()
        //{
        //    try
        //    {

        //        return Ok(context.Clientes.ToList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        [HttpGet]
        [Route("getClient")]
        public ActionResult getClient()
        {
            try
            {
                var cnts = context.Clientes.ToList();
                return Ok(cnts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
