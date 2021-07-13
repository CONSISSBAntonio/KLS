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
    [Route("Clients/Requirements")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RequirementsController : Controller
    {
        private readonly AppDbContext context;
        public RequirementsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Requisitos requisitos)
        {
            try
            {
                var Box = context.Cl_Has_Requisitos.FirstOrDefault(f => f.Id_Cliente == requisitos.Id_Cliente);
                return Ok(Box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Requisitos requisitos)
        {
            try
            {
                context.Cl_Has_Requisitos.Add(requisitos);
                context.SaveChanges();
                return Ok(requisitos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Requisitos requisitos)
        {
            try
            {
                context.Entry(requisitos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(requisitos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
