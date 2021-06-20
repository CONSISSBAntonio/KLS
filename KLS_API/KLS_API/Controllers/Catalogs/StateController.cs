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
    [Route("Catalogs/Geography/State")]
    public class StateController : Controller
    {
        private readonly AppDbContext context;
        public StateController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Estado.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Estado cat_estado)
        {
            try
            {
                context.Cat_Estado.Add(cat_estado);
                context.SaveChanges();
                return Ok(cat_estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cat_Estado cat_estado)
        {
            try
            {
                context.Entry(cat_estado).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(cat_estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
