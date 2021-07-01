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

namespace KLS_API.Controllers.Carriers.Inventory
{
    [Route("Carriers/Inventory")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InventoryController : Controller
    {
        private readonly AppDbContext context;
        public InventoryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Tr_Has_Inventario tr_inventario)
        {
            try
            {
                var rutas = context.Tr_Has_Inventario.Where(f => f.IdTransportista == tr_inventario.IdTransportista).ToList();
                return Ok(rutas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Inventario tr_inventario)
        {
            try
            {
                context.Tr_Has_Inventario.Add(tr_inventario);
                context.SaveChanges();
                return Ok(tr_inventario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Inventario tr_inventario)
        {
            try
            {
                context.Entry(tr_inventario).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_inventario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
