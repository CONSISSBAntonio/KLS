using System;
using System.Linq;
using KLS_API.Context;
using KLS_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KLS_API.Controllers.Catalogs.TypesOfUnits
{
    [Route("Catalogs/TypesOfUnits")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TypesOfUnitsController : Controller
    {
        private readonly AppDbContext context;
        public TypesOfUnitsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cat_Tipos_Unidades.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "getTipoUnidad")]
        public ActionResult Get(int id)
        {
            try
            {
                var tipo_unidad = context.Cat_Tipos_Unidades.FirstOrDefault(f => f.id == id);
                return Ok(tipo_unidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cat_Tipos_Unidades tipos_Unidades) 
        {
            try
            {
                context.Cat_Tipos_Unidades.Add(tipos_Unidades);
                context.SaveChanges();
                return CreatedAtRoute("getTipoUnidad",new { id = tipos_Unidades.id }, tipos_Unidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPut]
        public ActionResult Put([FromBody] Cat_Tipos_Unidades tipos_Unidades) 
        {
            try
            {
                context.Entry(tipos_Unidades).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("getTipoUnidad", new { id = tipos_Unidades.id }, tipos_Unidades);   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            try
            {
                var tipo_unidad = context.Cat_Tipos_Unidades.FirstOrDefault(f=>f.id==id);
                if (tipo_unidad!=null)
                {
                    context.Cat_Tipos_Unidades.Remove(tipo_unidad);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
