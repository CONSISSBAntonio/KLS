using KLS_API.Context;
using KLS_API.Models.Clients;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Clients
{
    [Route("Clients/Destinations")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class DestinationsController : Controller
    {
        private readonly AppDbContext context;
        public DestinationsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Destinos tr_origen)
        {
            try
            {
                var Origen = context.Cl_Has_Destinos.Where(f => f.Id_Cliente == tr_origen.Id_Cliente).ToList();
                return Ok(Origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Destinos tr_destinos)
        {
            try
            {
                context.Cl_Has_Destinos.Add(tr_destinos);
                context.SaveChanges();
                return Ok(tr_destinos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Destinos tr_destinos)
        {
            try
            {
                context.Entry(tr_destinos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_destinos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
