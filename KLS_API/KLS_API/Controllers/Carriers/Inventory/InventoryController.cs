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

        [HttpGet("[action]/{id}")]
        public IActionResult GetEquipos(int id)
        {
            try
            {
                var equipos = from inventario in context.Tr_Has_Inventario
                              join tipounidad in context.Cat_Tipos_Unidades on inventario.TipoUnidad equals tipounidad.id
                              where inventario.IdTransportista == id && inventario.Estatus == 1
                              select new
                              {
                                  inventario.Id,
                                  inventario.IdTransportista,
                                  inventario.Anio,
                                  inventario.Capacidad,
                                  inventario.Color,
                                  inventario.Estatus,
                                  inventario.Marca,
                                  inventario.Modelo,
                                  inventario.NoEconomico,
                                  inventario.NoSerie,
                                  inventario.Placa,
                                  tipounidad = tipounidad.id,
                                  tipounidadnombre = tipounidad.nombre,
                                  inventario.Volumen,
                                  inventario.Ruta,
                                  inventario.FotoUnidad,
                                  inventario.FotoPoliza
                              };

                return Ok(equipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
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

        [HttpGet("getInventario/{id}")]
        public IActionResult GetOperator(int id)
        {
            try
            {
                var aerolinea = context.Tr_Has_Inventario.FirstOrDefault(f => f.Id == id);
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
