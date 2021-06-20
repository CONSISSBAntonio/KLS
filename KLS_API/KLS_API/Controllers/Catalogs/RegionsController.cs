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
    [Route("Catalogs/Geography/Regions")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RegionsController : Controller
    {
        private readonly AppDbContext context;
        public RegionsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Region cat_region)
        {
            try
            {
                context.Cat_Region.Add(cat_region);
                context.SaveChanges();
                return Ok(cat_region);
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
                var Regiones = context.Cat_Region.Include(x => x.Region_Has_Estados).ToList();
                return Ok(Regiones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Region cat_region)
        {
            try
            {
                var datas = context.Region_Has_Estado.Where(b => EF.Property<int>(b, "Cat_RegionId") == cat_region.id);
                context.Region_Has_Estado.RemoveRange(datas);
                context.SaveChanges();

                if (cat_region.Region_Has_Estados.Count() > 0) {
                    foreach (var item in cat_region.Region_Has_Estados)
                    {
                        var dato_ = new Region_Has_Estado { Cat_RegionId = cat_region.id, id_estado = item.id_estado };
                        context.Region_Has_Estado.Add(dato_);
                        context.SaveChanges();
                    }
                }    
                
                context.Entry(cat_region).State = EntityState.Modified;
                context.SaveChanges();

                return Ok(cat_region);
                //return CreatedAtRoute("getAirline", new { id = cat_region.id }, cat_region);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
