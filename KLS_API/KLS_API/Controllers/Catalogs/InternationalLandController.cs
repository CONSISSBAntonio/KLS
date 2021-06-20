using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Catalogs.InternationalLand
{
    [Route("Catalogs/InternationalLand")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InternationalLandController : Controller
    {
        private readonly AppDbContext context;
        public InternationalLandController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Terrestres_Internacionales.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getInternational")]
        public ActionResult Get(int id)
        {
            try
            {
                var inter = context.Cat_Terrestres_Internacionales.FirstOrDefault(f => f.id == id);
                return Ok(inter);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Terrestres_Internacionales cat_terrestres)
        {
            //string asd = this._AuthService.GetCurrentUser().usuario;
            //cat_aerolinea.nombre = asd;
            try
            {
                context.Cat_Terrestres_Internacionales.Add(cat_terrestres);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Terrestres_Internacionales cat_terrestres_internacionales)
        {
            try
            {
                context.Entry(cat_terrestres_internacionales).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getInternational", new { id = cat_terrestres_internacionales.id }, cat_terrestres_internacionales); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
