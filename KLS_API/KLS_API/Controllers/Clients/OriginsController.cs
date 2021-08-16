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
    [Route("Clients/Origins")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OriginsController : Controller
    {
        private readonly AppDbContext context;
        public OriginsController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                IQueryable<object> queryable = null;
                queryable = (from destinos in context.Cl_Has_Origen
                             join estados in context.Cat_Estado on destinos.Id_Estado equals estados.id
                             join ciudades in context.Cat_Ciudad on destinos.Id_Ciudad equals ciudades.id
                             join colonias in context.Cat_Colonia on destinos.Id_Colonia equals colonias.id
                             where destinos.Id_Cliente == tr_origen.Id_Cliente
                             select new
                             {
                                 nombre = destinos.Nombre,
                                 cp = colonias.cp,
                                 estado = estados.nombre,
                                 ciudad = ciudades.nombre,
                                 direccion = destinos.Direccion,
                                 estatus = destinos.Estatus,
                                 id = destinos.Id,
                                 id_Estado = colonias.id_estado,
                                 id_Ciudad = colonias.id_ciudad,
                                 id_Colonia = colonias.id,
                                 HoraAtencion = destinos.HoraAtencion
                             }).ToList().AsQueryable();
                return Ok(queryable);
                //var Origen = context.Cl_Has_Origen.Where(f => f.Id_Cliente == tr_origen.Id_Cliente).ToList();
                //return Ok(Origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                context.Cl_Has_Origen.Add(tr_origen);
                context.SaveChanges();
                return Ok(tr_origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                context.Entry(tr_origen).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetOrigin(int id)
        {
            try
            {
                return Ok(context.Cl_Has_Origen.Find(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpGet("getColonias/{id}")]
        public IActionResult getColonias(int id)
        {
            try
            {
                var Colonias = context.Cat_Colonia.Where(f => f.id_ciudad == id).ToList();
                return Ok(Colonias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }
        
        [HttpGet("getCp/{cp}")]
        public IActionResult getCp(int cp)
        {
            try
            {
                var Colonias = context.Cat_Colonia.Where(f => f.cp == cp).ToList();
                return Ok(Colonias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }


    }
}
