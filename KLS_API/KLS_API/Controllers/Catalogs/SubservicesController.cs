using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Catalogs.subservices
{
    [Route("Catalogs/Subservices")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class subservicesController : Controller
    {
        private readonly AppDbContext context;
        public subservicesController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Subservicios.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getSubservice")]
        public ActionResult Get(int id)
        {
            try
            {
                var subservicio = context.Cat_Subservicios.FirstOrDefault(f => f.id == id);
                return Ok(subservicio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Subservicios cat_subservicios)
        {
            try
            {
                context.Cat_Subservicios.Add(cat_subservicios);
                context.SaveChanges();
                return CreatedAtRoute("getSubservice", new { id = cat_subservicios.id }, cat_subservicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Subservicios cat_subservicios)
        {
            try
            {
                context.Entry(cat_subservicios).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getSubservice", new { id = cat_subservicios.id }, cat_subservicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
