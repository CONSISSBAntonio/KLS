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
    [Route("Clients/Certifications")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CertificationsController : Controller
    {
        private readonly AppDbContext context;
        public CertificationsController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get([FromBody] Cl_Has_Certificacion tr_certificacion)
        {
            try
            {
                var Certificacion = context.Cl_Has_Certificacion.FirstOrDefault(f => f.Id_Cliente == tr_certificacion.Id_Cliente);
                return Ok(Certificacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Certificacion tr_certificacion)
        {
            try
            {
                context.Cl_Has_Certificacion.Add(tr_certificacion);
                context.SaveChanges();
                return Ok(tr_certificacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Certificacion tr_certificacion)
        {
            try
            {
                context.Entry(tr_certificacion).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_certificacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
