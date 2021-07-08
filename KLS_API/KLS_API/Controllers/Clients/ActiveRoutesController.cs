using KLS_API.Context;
using KLS_API.Models.Clients;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Clients
{
    [Route("Clients/ActiveRoutes")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ActiveRoutesController : Controller
    {
        private readonly AppDbContext context;
        public ActiveRoutesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cl_Has_Routes.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getRoute")]
        public ActionResult getCarrier([FromBody] Cl_Has_Routes clientes)
        {
            try
            {
                var clietes = context.Cl_Has_Routes.FirstOrDefault(f => f.Id == clientes.Id);
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Routes clietes)
        {
            try
            {
                context.Cl_Has_Routes.Add(clietes);
                context.SaveChanges();
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Routes clietes)
        {
            try
            {
                context.Entry(clietes).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
