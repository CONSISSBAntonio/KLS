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

        //Modificar
        [Route("getRuta")]
        public ActionResult getRuta([FromBody] RouteTran tr_rutas)
        {
            try
            {
                var rutas = context.Ruta.Where(f => f.estatus == 1).ToList().AsQueryable();

                if (tr_rutas.id_ciudadorigen != 0)
                {
                    rutas = rutas.Where(f => f.id_ciudadorigen == tr_rutas.id_ciudadorigen);
                }
                if (tr_rutas.id_estadoorigen != 0)
                {
                    rutas = rutas.Where(f => f.id_estadoorigen == tr_rutas.id_estadoorigen);
                }
                if (tr_rutas.id_ciudaddestino != 0)
                {
                    rutas = rutas.Where(f => f.id_ciudaddestino == tr_rutas.id_ciudaddestino);
                }
                if (tr_rutas.id_estadodestino != 0)
                {
                    rutas = rutas.Where(f => f.id_estadodestino == tr_rutas.id_estadodestino);
                }
                return Ok(rutas);
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
                context.Entry(tr_rutas).State = EntityState.Modified;
                context.SaveChanges();

                return Ok(tr_rutas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public class TravelServicePrice
        {
            public int CarrierRouteId { get; set; }
            public int TravelServiceId { get; set; }
            public decimal OneWayPrice { get; set; }
            public decimal TwoWayPrice { get; set; }
            public decimal CircuiteablePrice { get; set; }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddEditTravelServicePrice([FromBody] ICollection<TravelServicePrice> travelServicePrices)
        {
            try
            {
                foreach (var travelservice in travelServicePrices)
                {
                    ruta_has_inventario rutaInventario = await context.ruta_has_inventario.SingleOrDefaultAsync(x => x.Tr_Has_RutaId == travelservice.CarrierRouteId && x.TravelServiceId == travelservice.TravelServiceId);
                    if (rutaInventario is null)
                    {
                        ruta_has_inventario newRutaInventario = new ruta_has_inventario
                        {
                            Tr_Has_RutaId = travelservice.CarrierRouteId,
                            TravelServiceId = travelservice.TravelServiceId,
                            CostoOne = travelservice.OneWayPrice,
                            CostoTwo = travelservice.TwoWayPrice,
                            Circuito = travelservice.CircuiteablePrice
                        };
                        await context.ruta_has_inventario.AddAsync(newRutaInventario);
                        bool success = await context.SaveChangesAsync() > 0;

                        if (!success)
                        {
                            return BadRequest();
                        }
                    }
                    else
                    {
                        rutaInventario.Tr_Has_RutaId = travelservice.CarrierRouteId;
                        rutaInventario.TravelServiceId = travelservice.TravelServiceId;
                        rutaInventario.CostoOne = travelservice.OneWayPrice;
                        rutaInventario.CostoTwo = travelservice.TwoWayPrice;
                        rutaInventario.Circuito = travelservice.CircuiteablePrice;

                        await context.SaveChangesAsync();
                        //bool success = await context.SaveChangesAsync() > 0;
                        //if (!success)
                        //{
                        //    return BadRequest();
                        //}
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]/{Tr_Has_RutaId}")]
        public async Task<IActionResult> GetRutaInventario(int Tr_Has_RutaId)
        {
            try
            {
                ICollection<ruta_has_inventario> ruta_Has_Inventarios = await context.ruta_has_inventario.Where(x => x.Tr_Has_RutaId == Tr_Has_RutaId).ToListAsync();
                return Ok(ruta_Has_Inventarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
