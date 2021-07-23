using KLS_API.Context;
using KLS_API.Helpers;
using KLS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KLS_API.Controllers.Catalogs
{
    [Route("Catalogs/Geography/Colonies")]
    public class ColoniesController : Controller
    {
        private readonly AppDbContext context;
        public ColoniesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Colonia.ToList().Take(25));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("prueba")]
        public ActionResult prueba([FromQuery] Paginacion paginacion)
        {
            try
            {
                var queryable = context.Cat_Colonia.AsQueryable();
                HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadAMostrar);
                double conteo = queryable.Count();

                var colonias = new { 
                    colonias = queryable.Paginar(paginacion).ToList(),
                    total = conteo
                };
                return Ok(colonias);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getColonies")]
        public ActionResult Get(int id)
        {
            try
            {
                var subservicio = context.Cat_Colonia.FirstOrDefault(f => f.id == id);
                return Ok(subservicio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Colonia cat_colonia)
        {
            try
            {
                context.Cat_Colonia.Add(cat_colonia);
                context.SaveChanges();
                return Ok(cat_colonia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Colonia cat_colonia)
        {
            try
            {
                context.Entry(cat_colonia).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getColonies", new { id = cat_colonia.id }, cat_colonia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult DT()
        {
            try
            {
                var colonias = (from colonia in context.Cat_Colonia
                               where colonia.estatus == 1
                               join estado in context.Cat_Estado on colonia.id_estado equals estado.id
                               join ciudad in context.Cat_Ciudad on colonia.id_ciudad equals ciudad.id
                               select new
                               {
                                   colonia.id,
                                   estado = estado.nombre,
                                   ciudad = ciudad.nombre,
                                   colonia.cp,
                                   colonia.nombre,
                                   colonia.estatus
                               }).ToList();

                return Ok(colonias.Take(25));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
