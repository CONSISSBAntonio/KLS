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
    [Route("Clients/Checkpoints")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class CheckpointsController : Controller
    {
        private readonly AppDbContext context;
        public CheckpointsController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cl_Has_Checkpoint.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Checkpoint clietes)
        {
            try
            {
                context.Cl_Has_Checkpoint.Add(clietes);
                context.SaveChanges();
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Checkpoint clietes)
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
