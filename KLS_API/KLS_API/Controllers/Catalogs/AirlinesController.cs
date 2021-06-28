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

namespace KLS_API.Controllers.Catalogs
{
    [Route("Catalogs/Airlines")]
    //[ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AirlinesController : Controller
    {
        private readonly AppDbContext context;
        public AirlinesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}", Name = "getAirline")]
        public ActionResult Get(int id)
        {
            try
            {
                var aerolinea = context.Cat_Aerolinea.FirstOrDefault(f => f.id == id);
                return Ok(aerolinea);
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
                return Ok(context.Cat_Aerolinea.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Aerolinea cat_aerolinea)
        {
            try
            {
                context.Cat_Aerolinea.Add(cat_aerolinea);
                context.SaveChanges();
                return Ok(cat_aerolinea);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Aerolinea cat_aerolinea)
        {
            try
            {
                context.Entry(cat_aerolinea).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(cat_aerolinea);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
