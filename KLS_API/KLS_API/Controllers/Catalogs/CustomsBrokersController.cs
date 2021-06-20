using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Catalogs.CustomsBrokers
{
    [Route("Catalogs/CustomsBrokers")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CustomsBrokersController : Controller
    {
        private readonly AppDbContext context;
        public CustomsBrokersController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Agentes_Aduanales.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getCustoms")]
        public ActionResult Get(int id)
        {
            try
            {
                var agentes = context.Cat_Agentes_Aduanales.FirstOrDefault(f => f.id == id);
                return Ok(agentes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Agentes_Aduanales cat_agentes_aduanales)
        {
            try
            {
                context.Cat_Agentes_Aduanales.Add(cat_agentes_aduanales);
                context.SaveChanges();
                return CreatedAtRoute("getCustoms", new { id = cat_agentes_aduanales.id }, cat_agentes_aduanales);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Agentes_Aduanales cat_agentes_aduanales)
        {
            try
            {
                context.Entry(cat_agentes_aduanales).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getCustoms", new { id = cat_agentes_aduanales.id }, cat_agentes_aduanales);   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
