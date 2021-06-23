using KLS_API.Context;
using KLS_API.Models.Carriers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Carriers
{
    [Route("Carriers")]
    public class CarriersController : Controller
    {
        private readonly AppDbContext context;
        public CarriersController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Transportista.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        [Route("getCarrier")]
        public ActionResult getCarrier([FromBody] Transportista transportista)
        {
            try
            {
                var aerolinea = context.Transportista.FirstOrDefault(f => f.id == transportista.id);
                return Ok(aerolinea);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Transportista transportista)
        {
            try
            {
                context.Transportista.Add(transportista);
                context.SaveChanges();
                return Ok(transportista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Transportista transportista)
        {
            try
            {
                context.Entry(transportista).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(transportista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
