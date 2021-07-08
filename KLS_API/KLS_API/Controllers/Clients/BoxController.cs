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
    [Route("Clients/Box")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BoxController : Controller
    {
        private readonly AppDbContext context;
        public BoxController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Box tr_box)
        {
            try
            {
                var Box = context.Cl_Has_Box.FirstOrDefault(f => f.Id_Cliente== tr_box.Id_Cliente);
                return Ok(Box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Box tr_box)
        {
            try
            {
                context.Cl_Has_Box.Add(tr_box);
                context.SaveChanges();
                return Ok(tr_box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Box tr_box)
        {
            try
            {
                context.Entry(tr_box).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
