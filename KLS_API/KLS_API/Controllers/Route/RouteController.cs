using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Route
{
    [Route("Route")]
    public class RouteController : Controller
    {
        private readonly AppDbContext context;
        public RouteController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("getRoute/{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var ruta = context.Ruta.FirstOrDefault(f => f.id == id);
                return Ok(ruta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getRoute")]
        public ActionResult GetR(int id)
        {
            try
            {
                var ruta = context.Ruta.FirstOrDefault(f => f.id == id);
                return Ok(ruta);
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
                return Ok(context.Ruta.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ruta ruta)
        {
            try
            {
                context.Ruta.Add(ruta);
                context.SaveChanges();
                return Ok(ruta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public ActionResult Put([FromBody] Ruta ruta)
        {
            try
            {
                context.Entry(ruta).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getRoute", new { id = ruta.id }, ruta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
