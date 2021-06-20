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
    [Route("Catalogs/Geography/City")]
    public class CityController : Controller
    {
        private readonly AppDbContext context;
        public CityController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}", Name = "getCity")]
        public ActionResult Get(int id)
        {
            try
            {
                var ciudad = context.Cat_Ciudad.FirstOrDefault(f => f.id == id);
                return Ok(ciudad);
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
                return Ok(context.Cat_Ciudad.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Ciudad cat_ciudad)
        {
            try
            {
                context.Cat_Ciudad.Add(cat_ciudad);
                context.SaveChanges();
                return Ok(cat_ciudad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Ciudad cat_ciudad)
        {
            try
            {
                context.Entry(cat_ciudad).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getCity", new { id = cat_ciudad.id }, cat_ciudad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
