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

namespace KLS_API.Controllers.Carriers.Routes
{
    [Route("Carriers/Routes")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RoutesController : Controller
    {
        private readonly AppDbContext context;
        public RoutesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Tr_Has_Ruta tr_rutas)
        {
            try
            {
                var asd = context.Tr_Has_Rutas.Where(f => f.Id_Transportista == tr_rutas.Id_Transportista).ToList();
                return Ok(asd);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Ruta tr_rutas)
        {
            try
            {
                context.Tr_Has_Rutas.Add(tr_rutas);
                context.SaveChanges();
                return Ok(tr_rutas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Ruta tr_rutas)
        {
            try
            {
                context.Entry(tr_rutas).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_rutas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
