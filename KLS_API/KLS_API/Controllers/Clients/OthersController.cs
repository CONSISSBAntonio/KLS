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
    [Route("Clients/Others")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OthersController : Controller
    {
        private readonly AppDbContext context;
        public OthersController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Evidencia evidencia)
        {
            try
            {
                var Origen = context.Cl_Has_Evidencia.Where(f => f.Id_Cliente == evidencia.Id_Cliente).ToList();
                return Ok(Origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Evidencia evidencia)
        {
            try
            {
                context.Cl_Has_Evidencia.Add(evidencia);
                context.SaveChanges();
                return Ok(evidencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Evidencia evidencia)
        {
            try
            {
                context.Entry(evidencia).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(evidencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //------------------------------------------------------------------------------------>Otros
        [HttpGet]
        [Route("getOtros")]
        public ActionResult getOtros([FromBody] Cl_Has_Otros evidencia)
        {
            try
            {
                var Origen = context.Cl_Has_Otros.FirstOrDefault(f => f.Id_Cliente == evidencia.Id_Cliente);
                return Ok(Origen);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("setOtros")]
        public ActionResult Post([FromBody] Cl_Has_Otros evidencia)
        {
            try
            {
                context.Cl_Has_Otros.Add(evidencia);
                context.SaveChanges();
                return Ok(evidencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("putOtros")]
        public ActionResult putOtros([FromBody] Cl_Has_Otros evidencia)
        {
            try
            {
                context.Entry(evidencia).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(evidencia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
