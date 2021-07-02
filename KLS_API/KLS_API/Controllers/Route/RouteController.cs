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
        private readonly AppDbContext _context;
        public RouteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getRoute/{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var ruta = _context.Ruta.FirstOrDefault(f => f.id == id);
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
                var ruta = _context.Ruta.FirstOrDefault(f => f.id == id);
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
                return Ok(_context.Ruta.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult SelectRoute()
        {
            var catalogo = from routes in _context.Ruta
                           join fromstate in _context.Cat_Estado on routes.id_estadoorigen equals fromstate.id
                           join tostate in _context.Cat_Estado on routes.id_estadodestino equals tostate.id
                           where routes.estatus == 1
                           select new
                           {
                               routes.id,
                               fromto = string.Concat(fromstate.nombre, "-", tostate.nombre)
                           };

            return Ok(catalogo);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Ruta ruta)
        {
            try
            {
                _context.Ruta.Add(ruta);
                _context.SaveChanges();
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
                _context.Entry(ruta).State = EntityState.Modified;
                _context.SaveChanges();
                return CreatedAtRoute("getRoute", new { id = ruta.id }, ruta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
