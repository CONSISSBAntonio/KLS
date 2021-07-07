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

namespace KLS_API.Controllers.Carriers.CarriersOperators
{
    [Route("Carriers/Operators")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OperatorsController : Controller
    {
        private readonly AppDbContext context;
        public OperatorsController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Get([FromBody] Tr_Has_Operadores tr_operadores)
        {
            try
            {
                var rutas = context.Tr_Has_Operadores.Where(f => f.Id_Transportista == tr_operadores.Id_Transportista).ToList();
                return Ok(rutas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Operadores tr_operadores)
        {
            try
            {
                context.Tr_Has_Operadores.Add(tr_operadores);
                context.SaveChanges();
                return Ok(tr_operadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Operadores tr_operadores)
        {
            try
            {
                context.Entry(tr_operadores).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_operadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetOperator(int id)
        {
            try
            {
                var aerolinea = context.Tr_Has_Operadores.FirstOrDefault(f => f.Id == id);
                return Ok(aerolinea);
                //return Ok(context.Tr_Has_Operadores.Find(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
