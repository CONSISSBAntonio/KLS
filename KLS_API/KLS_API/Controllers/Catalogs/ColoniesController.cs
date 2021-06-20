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
                return Ok(context.Cat_Colonia.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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

    }
}
