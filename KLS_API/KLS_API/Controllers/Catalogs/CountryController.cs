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
    [Route("Catalogs/Geography/Country")]
    public class CountryController : Controller
    {
        private readonly AppDbContext context;
        public CountryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Pais.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Pais cat_pais)
        {
            try
            {
                context.Cat_Pais.Add(cat_pais);
                context.SaveChanges();
                return Ok(cat_pais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Pais cat_pais)
        {
            try
            {
                context.Entry(cat_pais).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(cat_pais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
