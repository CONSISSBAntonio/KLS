using KLS_API.Context;
using KLS_API.Models.Oferta;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KLS_API.Controllers
{
    [Route("Offer")]
    [ApiController]
    public class OfferController : Controller
    {
        private readonly AppDbContext context;
        public OfferController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Oferta tr_rutas)
        {
            try
            {
                IQueryable<object> queryable = null;
                queryable = (from oferta in context.Oferta
                             join estadoorigen in context.Cat_Estado on oferta.Estado_Origen equals estadoorigen.id
                             join ciudadorigen in context.Cat_Ciudad on oferta.ciudad_Origen equals ciudadorigen.id
                             join regionorigen in context.Cat_Region on oferta.Region_Origen equals regionorigen.id
                             join estadodestino in context.Cat_Estado on oferta.Estado_Origen equals estadodestino.id
                             join ciudaddestino in context.Cat_Ciudad on oferta.ciudad_Origen equals ciudaddestino.id
                             join regiondestino in context.Cat_Region on oferta.Region_Origen equals regiondestino.id
                             join tipounidad in context.Cat_Tipos_Unidades on oferta.Tipo_De_Unidad equals tipounidad.id
                             select new
                             {
                                 estadoorigen = estadoorigen.nombre,
                                 ciudadorigen = ciudadorigen.nombre,
                                 ciudaddestino = ciudaddestino.nombre,
                                 estadodestino = estadodestino.nombre,
                                 tipounidad = tipounidad.nombre,
                                 fechadisponibilidad = oferta.Fecha_Disponibilidad,
                             }).ToList().AsQueryable();
                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("busquedas")]
        public ActionResult busquedas([FromBody] ofertas busqueda)
        {
            try
            {
                var queryable = (from oferta in context.Oferta
                                 where oferta.status != 3
                                 join tipounidad in context.Cat_Tipos_Unidades on oferta.Tipo_De_Unidad equals tipounidad.id
                                 join transportista in context.Transportista on oferta.Transportista equals transportista.id
                                 where transportista.Estatus != 0
                                 orderby oferta.Fecha_Disponibilidad
                                 select new ofertas
                                 {
                                     idestadoorigen = oferta.Estado_Origen,
                                     idestadodestino = oferta.estado_Destino,
                                     idciudadorigen = oferta.ciudad_Origen,
                                     idciudaddestino = oferta.ciudad_Destino,
                                     tipounidad = tipounidad.nombre,
                                     idtipounidad = tipounidad.id,
                                     fechadisponibilidad = oferta.Fecha_Disponibilidad,
                                     transportista = transportista.NivelServicio,
                                     idtransportista = transportista.id,
                                     status = oferta.status,
                                     nombreTran = transportista.NombreComercial,
                                     seltransportista = transportista.id,
                                     nivelOrigen = oferta.Nivel_Origen,
                                     nivelDestino = oferta.Nivel_Destino,
                                     idregionOrigen = oferta.Region_Origen,
                                     idregionDestino = oferta.Region_Destino,
                                     idoferta = oferta.Id,
                                 }).ToList().AsQueryable();

                if (busqueda.idestadoorigen != 0)
                {
                    queryable = queryable.Where(x => x.idestadoorigen == busqueda.idestadoorigen);
                }
                if (busqueda.idestadodestino != 0)
                {
                    queryable = queryable.Where(x => x.idestadodestino == busqueda.idestadodestino);
                }
                if (busqueda.idciudadorigen != 0)
                {
                    queryable = queryable.Where(x => x.idciudadorigen == busqueda.idciudadorigen);
                }
                if (busqueda.idciudaddestino != 0)
                {
                    queryable = queryable.Where(x => x.idciudaddestino == busqueda.idciudaddestino);
                }
                if (busqueda.idtipounidad != 0)
                {
                    queryable = queryable.Where(x => x.idtipounidad == busqueda.idtipounidad);
                }
                if (busqueda.transportista != 0)
                {
                    queryable = queryable.Where(x => x.transportista == busqueda.transportista);
                }
                if (busqueda.seltransportista != 0)
                {
                    queryable = queryable.Where(x => x.seltransportista == busqueda.seltransportista);
                }
                //DateTime temp;
                //if (DateTime.TryParse(busqueda.fechadisponibilidad.Date.ToString(),out temp)==true)
                //{
                //    queryable = queryable.Where(x => x.fechadisponibilidad.Date.ToString().Contains(busqueda.fechadisponibilidad.Date.ToString()));
                //}

                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Obtener transportistas
        [Route("getTransportistas")]
        public ActionResult getTransportistas()
        {
            try
            {
                var queryable = (from oferta in context.Oferta
                                 join estadoorigen in context.Cat_Estado on oferta.Estado_Origen equals estadoorigen.id
                                 join ciudadorigen in context.Cat_Ciudad on oferta.ciudad_Origen equals ciudadorigen.id
                                 join regionorigen in context.Cat_Region on oferta.Region_Origen equals regionorigen.id
                                 orderby oferta.Fecha_Disponibilidad
                                 select new ofertas
                                 {
                                     estadoorigen = estadoorigen.nombre,
                                     idestadoorigen = estadoorigen.id,
                                     idciudadorigen = ciudadorigen.id,
                                 }).ToList().AsQueryable();
                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Carga carg)
        {
            try
            {
                foreach (var item in carg.catCarga)
                {
                    var dato_ = new Oferta
                    {
                        Transportista = item.Transportista,
                        Tipo_De_Unidad = item.Tipo_De_Unidad,
                        Cantidad = item.Cantidad,
                        Fecha_Disponibilidad = item.Fecha_Disponibilidad,
                        Rango_De_Espera = item.Rango_De_Espera,
                        Nivel_Origen = item.Nivel_Origen,
                        Region_Origen = item.Region_Origen,
                        Estado_Origen = item.Estado_Origen,
                        ciudad_Origen = item.ciudad_Origen,
                        Tolerancia_Origen = item.Tolerancia_Origen,
                        Tolerancia_Destino = item.Tolerancia_Destino,
                        Nivel_Destino = item.Nivel_Destino,
                        Region_Destino = item.Region_Destino,
                        estado_Destino = item.estado_Destino,
                        ciudad_Destino = item.ciudad_Destino,
                        status = item.status
                    };
                    context.Oferta.Add(dato_);
                    context.SaveChanges();
                }
                return Ok(carg);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public class ofertas
        {
            public int idestadoorigen { get; set; }
            public int idestadodestino { get; set; }
            public int idciudadorigen { get; set; }
            public int idciudaddestino { get; set; }
            public int seltransportista { get; set; }
            public int idtipounidad { get; set; }
            public string estadoorigen { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public string estadodestino { get; set; }
            public string tipounidad { get; set; }
            public DateTime fechadisponibilidad { get; set; }
            public int transportista { get; set; }
            public int status { get; set; }
            public int idtransportista { get; set; }
            public string nombreTran { get; set; }
            public string nivelOrigen { get; set; }
            public string nivelDestino { get; set; }
            public int idregionOrigen { get; set; }
            public int idregionDestino { get; set; }
            public int idoferta { get; set; }
        }

        //Function de obtener listado de todas las rutas del transportista
        [HttpGet]
        [Route("listTransportistas")]
        public ActionResult listTransportistas()
        {
            try
            {
                
                IQueryable<object> queryable = null;
                queryable = (from tr_r in context.Tr_Has_Ruta
                             join ruta in context.Ruta on tr_r.Id_Ruta equals ruta.id
                             join transportista in context.Transportista on tr_r.Id_Transportista equals transportista.id
                             join estadoorigen in context.Cat_Estado on ruta.id_estadoorigen equals estadoorigen.id
                             join estadodestino in context.Cat_Estado on ruta.id_estadodestino equals estadodestino.id
                             join ciudadorigen in context.Cat_Ciudad on ruta.id_ciudadorigen equals ciudadorigen.id
                             join ciudaddestino in context.Cat_Ciudad on ruta.id_ciudaddestino equals ciudaddestino.id
                             select new listTran
                             {
                                 nombre = transportista.NombreComercial,
                                 idesorigen = ruta.id_estadoorigen,
                                 idesdestino = ruta.id_estadodestino,
                                 idcorigen = ruta.id_ciudadorigen,
                                 idcdestino = ruta.id_ciudaddestino,
                                 estadoorigen = estadoorigen.nombre,
                                 estadodestino = estadodestino.nombre,
                                 ciudadorigen = ciudadorigen.nombre,
                                 ciudaddestino = ciudaddestino.nombre,
                                 costo = tr_r.Costo,
                                 estatus = tr_r.Estatus
                             }).ToList().AsQueryable();

                return Ok(queryable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        public class listTran{
            public string nombre { get; set; }
            public int idesorigen { get; set; }
            public int idesdestino { get; set; }
            public int idcorigen { get; set; }
            public int idcdestino { get; set; }
            public string estadoorigen { get; set; }
            public string estadodestino { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public decimal costo { get; set; }
            public int estatus { get; set; }
        }
        
        [HttpGet]
        [Route("obOferta")]
        public ActionResult obOferta([FromBody] int id)
        {
            try
            {
                var oferta = context.Oferta.FirstOrDefault(f => f.Id == id);
                return Ok(oferta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("putOferta")]
        public ActionResult putOferta([FromBody] Oferta oferta)
        {
            try
            {
                context.Entry(oferta).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(oferta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //Separar
        [HttpPost]
        [Route("Separar")]
        public ActionResult Separar([FromBody] Separar separar)
        {
            try
            {
                var dato_ = new Oferta { Id = separar.id_oferta, status = 2 };
                context.Attach(dato_);
                context.Entry(dato_).Property("status").IsModified = true;
                context.SaveChanges();

                context.Separar.Add(separar);
                context.SaveChanges();
                return Ok(separar);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        [Route("getSeparar")]
        public ActionResult getSeparar([FromBody] Separar separar)
        {
            try
            {
                var getseparar = context.Separar.FirstOrDefault(f => f.id_oferta == separar.id_oferta);
                return Ok(getseparar);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("putSeparar")]
        public ActionResult putSeparar([FromBody] Separar separar)
        {
            try
            {
                context.Entry(separar).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(separar);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("[action]/{Id}")]
        public IActionResult GetOffer(int Id)
        {
            try
            {
                return Ok(context.Oferta.Find(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

    }
}

