using KLS_API.Context;
using KLS_API.Models.Clients;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Clients
{
    [Route("Clients/Destinations")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class DestinationsController : Controller
    {
        private readonly AppDbContext context;
        public DestinationsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Destinos tr_origen)
        {
            try
            {
                //var Origen = context.Cl_Has_Destinos.Where(f => f.Id_Cliente == tr_origen.Id_Cliente).ToList();
                //return Ok(Origen);
                IQueryable<object> queryable = null;
                queryable = (from destinos in context.Cl_Has_Destinos
                             join estados in context.Cat_Estado on destinos.Id_Estado equals estados.id
                             join ciudades in context.Cat_Ciudad on destinos.Id_Ciudad equals ciudades.id
                             join colonias in context.Cat_Colonia on destinos.Id_Colonia equals colonias.id
                             where destinos.Id_Cliente == tr_origen.Id_Cliente
                             select new
                             {
                                 nombre = destinos.Nombre,
                                 cp= colonias.cp,
                                 estado = estados.nombre,
                                 ciudad = ciudades.nombre,
                                 direccion = destinos.Direccion,
                                 estatus = destinos.Estatus,
                                 id = destinos.Id,
                             }).ToList().AsQueryable();
                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Destinos tr_destinos)
        {
            try
            {
                context.Cl_Has_Destinos.Add(tr_destinos);
                context.SaveChanges();
                return Ok(tr_destinos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Destinos tr_destinos)
        {
            try
            {
                context.Entry(tr_destinos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_destinos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetDestination(int id)
        {
            try
            {
                return Ok(context.Cl_Has_Destinos.Find(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

    }
}
