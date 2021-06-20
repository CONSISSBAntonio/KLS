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
using System.Net;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Catalogs.Coloaders
{
    [Route("Catalogs/Coloaders")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ColoadersController : Controller
    {
        private readonly AppDbContext context;
        public ColoadersController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Coloaders.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getCoLoaders")]
        public ActionResult Get(int id)
        {
            try
            {
                var subservicio = context.Cat_Coloaders.FirstOrDefault(f => f.id == id);
                return Ok(subservicio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Coloaders cat_co_loaders)
        {
            try
            {
                context.Cat_Coloaders.Add(cat_co_loaders);
                context.SaveChanges();
                return CreatedAtRoute("getCoLoaders", new { id = cat_co_loaders.id }, cat_co_loaders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put(int id, [FromBody] Cat_Coloaders cat_co_loaders)
        {
            try
            {
                
                context.Entry(cat_co_loaders).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getColoaders", new { id = cat_co_loaders.id }, cat_co_loaders);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
