using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Adapters;
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
                ruta.Folio = string.Concat(ruta.id_ciudadorigen.ToString("D4"), ruta.id_ciudaddestino.ToString("D4"));
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
                ruta.Folio = string.Concat(ruta.id_ciudadorigen.ToString("D4"), ruta.id_ciudaddestino.ToString("D4"));
                _context.Entry(ruta).State = EntityState.Modified;
                _context.SaveChanges();
                return CreatedAtRoute("getRoute", new { id = ruta.id }, ruta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //public class DTModel
        //{
        //    public int Id { get; set; }
        //    public string Folio { get; set; }
        //    public string EstadoOrigen { get; set; }
        //    public string CiudadOrigen { get; set; }
        //    public string EstadoDestino { get; set; }
        //    public string CiudadDestino { get; set; }
        //    public int KM { get; set; }
        //    public string Seguridad { get; set; }
        //    public string Estatus { get; set; }
        //}

        //[HttpGet]
        //public ActionResult DT()
        //{
        //    try
        //    {
        //        List<DTModel> rutas = _context.Ruta.Where(x => x.estatus == 1).Select(x => new DTModel
        //        {
        //            Id = x.id,
        //            Folio = x.Folio,
        //            EstadoOrigen = _context.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadoorigen).nombre.ToUpper(),
        //            CiudadOrigen = _context.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudadorigen).nombre.ToUpper(),
        //            EstadoDestino = _context.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadodestino).nombre.ToUpper(),
        //            CiudadDestino = _context.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudaddestino).nombre.ToUpper(),
        //            KM = x.totalkilometros,
        //            Seguridad = x.seguridad,
        //            Estatus = x.estatus == 1 ? "ACTIVO" : "INACTIVO",
        //        }).ToList();

        //        return Ok(rutas);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //        throw;
        //    }
        //}

        [HttpPatch]
        [Route("[action]/{RouteId}")]
        public IActionResult PatchRoute(int RouteId, [FromBody] JsonPatchDocument<Ruta> patchDoc)
        {
            var route = _context.Ruta.Find(RouteId);
            if (route == null)
            {
                return NotFound();
            }
            if (patchDoc == null)
            {
                return BadRequest();
            }

            patchDoc.ApplyTo(route);

            _context.SaveChanges();
            return Ok(route);
        }
    }
}
