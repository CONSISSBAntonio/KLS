using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace KLS_API.Controllers.Catalogs.ShippingCompanies
{
    [Route("Catalogs/ShippingCompanies")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ShippingCompaniesController : Controller
    {
        private readonly AppDbContext context;
        public ShippingCompaniesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Navieras.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getShipping")]
        public ActionResult Get(int id)
        {
            try
            {
                var navieras = context.Cat_Navieras.FirstOrDefault(f => f.id == id);
                return Ok(navieras);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Navieras cat_navieras)
        {
            //string asd = this._AuthService.GetCurrentUser().usuario;
            //cat_aerolinea.nombre = asd;
            try
            {
                context.Cat_Navieras.Add(cat_navieras);
                context.SaveChanges();
                return CreatedAtRoute("getShipping", new { id = cat_navieras.id }, cat_navieras);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Navieras cat_navieras)
        {
            try
            {
                context.Entry(cat_navieras).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getShipping", new { id = cat_navieras.id }, cat_navieras); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
