using KLS_API.Context;
using KLS_API.Models.Clients;
using KLS_API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Clients
{
    [Route("Clients/ActiveRoutes")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ActiveRoutesController : Controller
    {
        private readonly AppDbContext context;
        public ActiveRoutesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cl_Has_Routes.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("getRoute")]
        public ActionResult getRoute([FromBody] Cl_Has_Routes clientes)
        {
            try
            {
                IQueryable<object> queryable = null;
                queryable = (from clrutas in context.Cl_Has_Routes
                                 where clrutas.Id_Cliente == clientes.Id_Cliente
                                 join rutas in context.Ruta on clrutas.Id_Ruta equals rutas.id
                                 join estadoorigen in context.Cat_Estado on rutas.id_estadoorigen equals estadoorigen.id
                                 join estadodestino in context.Cat_Estado on rutas.id_estadodestino equals estadodestino.id
                                 select new clRoutes
                                 {
                                     id = clrutas.Id,
                                     idcliente = clrutas.Id_Cliente_Kls,
                                     idorigen = rutas.id_estadoorigen,
                                     origen = estadoorigen.nombre,
                                     iddestino = rutas.id_estadodestino,
                                     destino = estadodestino.nombre,
                                     tiemporuta = rutas.tiemporuta,
                                     monitoreable = clrutas.Monitoreable,
                                     status = clrutas.Estatus,
                                     idcorigen = rutas.id_ciudadorigen,
                                     idcdestino = rutas.id_ciudaddestino,
                                     idruta = rutas.id
                                 }).ToList().AsQueryable();
                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public class clRoutes
        {
            public int id { get; set; }
            public int idcliente { get; set; }
            public int idorigen { get; set; }
            public string origen { get; set; }
            public int iddestino { get; set; }
            public string destino { get; set; }
            public int tiemporuta { get; set; }
            public bool monitoreable { get; set; }
            public int status { get; set; }
            public int idcorigen { get; set; }
            public int idcdestino { get; set; }
            public int idruta { get; set; }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cl_Has_Routes clietes)
        {
            try
            {
                context.Cl_Has_Routes.Add(clietes);
                context.SaveChanges();
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cl_Has_Routes clietes)
        {
            try
            {
                context.Entry(clietes).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(clietes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        [Route("getRoutes")]
        public ActionResult getRoutes([FromBody] Ruta routes)
        {
            try
            {
                var queryable = (from rutas in context.Ruta
                                 join estadoorigen in context.Cat_Estado on rutas.id_estadoorigen equals estadoorigen.id
                                 join ciudadorigen in context.Cat_Ciudad on rutas.id_ciudadorigen equals ciudadorigen.id
                                 join estadodestino in context.Cat_Estado on rutas.id_estadodestino equals estadodestino.id
                                 join ciudaddestino in context.Cat_Ciudad on rutas.id_ciudaddestino equals ciudaddestino.id
                                 select new routeActives
                                 {
                                     id = rutas.id,
                                     idestadoorigen = estadoorigen.id,
                                     idciudadorigen = ciudadorigen.id,
                                     idestadodestino = estadodestino.id,
                                     idciudaddestino = ciudaddestino.id,
                                     estadoOrigen = estadoorigen.nombre,
                                     ciudadOrigen = ciudadorigen.nombre,
                                     estadoDestino = estadodestino.nombre,
                                     ciudadDestino = ciudaddestino.nombre,
                                 }).ToList().AsQueryable();
                
                if (routes.id_estadoorigen != 0)
                {
                    queryable = queryable.Where(x => x.idestadoorigen == routes.id_estadoorigen);
                }
                if (routes.id_ciudadorigen != 0)
                {
                    queryable = queryable.Where(x => x.idciudadorigen == routes.id_ciudadorigen);
                }
                if (routes.id_estadodestino != 0)
                {
                    queryable = queryable.Where(x => x.idestadodestino == routes.id_estadodestino);
                }
                if (routes.id_ciudaddestino != 0)
                {
                    queryable = queryable.Where(x => x.idciudaddestino == routes.id_ciudaddestino);
                }

                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public class routeActives
        {
            public int id { get; set; }
            public int idestadoorigen { get; set; }
            public int idciudadorigen { get; set; }
            public int idestadodestino { get; set; }
            public int idciudaddestino { get; set; }
            public string estadoOrigen { get; set; }
            public string ciudadOrigen { get; set; }
            public string estadoDestino { get; set; }
            public string ciudadDestino { get; set; }
        }

    }
}
