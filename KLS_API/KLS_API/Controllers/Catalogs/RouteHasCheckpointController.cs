using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Catalogs
{
    [Route("RouteHasCheckpoint")]
    public class RouteHasCheckpointController : Controller
    {
        private readonly AppDbContext context;
        public RouteHasCheckpointController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}", Name = "getRouteHasCheckpoint")]
        public ActionResult Get(int id)
        {
            try
            {
                var ciudad = context.Ruta_Has_Checkpoint.FirstOrDefault(f => f.id == id);
                return Ok(ciudad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getRouteCheckpoint/{rutaid}")]
        public ActionResult getRouteCheckpoint(int rutaid)
        {
            try
            {
                return Ok(context.Ruta_Has_Checkpoint.Where(x => x.RutaId == rutaid).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Ruta_Has_Checkpoint.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ruta_Has_Checkpoint ruta_Has_Checkpoint)
        {
            try
            {
                context.Ruta_Has_Checkpoint.Add(ruta_Has_Checkpoint);
                context.SaveChanges();
                return Ok(ruta_Has_Checkpoint);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Ruta_Has_Checkpoint ruta_Has_Checkpoint)
        {
            try
            {
                context.Entry(ruta_Has_Checkpoint).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getRouteHasCheckpoint", new { id = ruta_Has_Checkpoint.id }, ruta_Has_Checkpoint);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Ruta_Has_Checkpoint ruta_Has_Checkpoint)
        {
            try
            {
                context.Entry(ruta_Has_Checkpoint).State = EntityState.Deleted;
                context.SaveChanges();
                return Ok(ruta_Has_Checkpoint);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
