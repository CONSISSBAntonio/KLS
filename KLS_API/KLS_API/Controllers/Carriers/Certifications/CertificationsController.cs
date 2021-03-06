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

namespace KLS_API.Controllers.Carriers.Certifications
{
    [Route("Carriers/Certifications")]
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
        public ActionResult Get([FromBody] Tr_Has_Certificacion tr_certificacion)
        {
            try
            {
                var Certificacion = context.Tr_Has_Certificacion.FirstOrDefault(f => f.Id_Transportista == tr_certificacion.Id_Transportista);
                return Ok(Certificacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Certificacion tr_certificacion)
        {
            try
            {
                context.Tr_Has_Certificacion.Add(tr_certificacion);
                context.SaveChanges();
                return Ok(tr_certificacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Certificacion tr_certificacion)
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
