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
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
                var asd = context.Tr_Has_Rutas.Include(x => x.ruta_has_inventario).Where(f => f.Id_Transportista == tr_rutas.Id_Transportista).ToList();
                return Ok(asd);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("getRuta")]
        public ActionResult getRuta([FromBody] RouteTran tr_rutas)
        {
            try
            {
                var asd = context.Ruta.Where(f => f.id_ciudadorigen == tr_rutas.id_ciudadorigen || f.id_estadoorigen == tr_rutas.id_estadoorigen || f.id_ciudaddestino == tr_rutas.id_ciudaddestino || f.id_estadodestino == tr_rutas.id_estadodestino).ToList();
                return Ok(asd);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [Route("obRutas")]
        public ActionResult obRutas()
        {
            try
            {
                var asd = context.Ruta.ToList();
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

                var datas = context.ruta_has_inventario.Where(b => EF.Property<int>(b, "Tr_Has_RutaId") == tr_rutas.Id);
                context.ruta_has_inventario.RemoveRange(datas);
                context.SaveChanges();

                if (tr_rutas.ruta_has_inventario.Count() > 0)
                {
                    foreach (var item in tr_rutas.ruta_has_inventario)
                    {
                        var dato_ = new ruta_has_inventario { Tr_Has_RutaId = tr_rutas.Id, Id_Inventario = item.Id_Inventario,Circuito = item.Circuito,CostoOne=item.CostoOne, CostoTwo = item.CostoTwo };
                        context.ruta_has_inventario.Add(dato_);
                        context.SaveChanges();
                    }
                }

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
