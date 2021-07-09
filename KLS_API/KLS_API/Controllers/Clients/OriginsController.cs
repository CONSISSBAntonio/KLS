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
    [Route("Clients/Origins")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OriginsController : Controller
    {
        private readonly AppDbContext context;
        public OriginsController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                var Origen = context.Cl_Has_Origen.Where(f => f.Id_Cliente == tr_origen.Id_Cliente).ToList();
                return Ok(Origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                context.Cl_Has_Origen.Add(tr_origen);
                context.SaveChanges();
                return Ok(tr_origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Origen tr_origen)
        {
            try
            {
                context.Entry(tr_origen).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
