using KLS_API.Context;
using KLS_API.Models.Carriers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Carriers.Box
{
    [Route("Carriers/Box")]
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
        public ActionResult Get([FromBody] Tr_Has_Box tr_box)
        {
            try
            {
                var Box = context.Tr_Has_Box.FirstOrDefault(f => f.Id_Transportista == tr_box.Id_Transportista);
                return Ok(Box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Box tr_box)
        {
            try
            {
                context.Tr_Has_Box.Add(tr_box);
                context.SaveChanges();
                return Ok(tr_box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Box tr_box)
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
