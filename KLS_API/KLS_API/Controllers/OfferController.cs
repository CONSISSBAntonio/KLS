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
                             join estadoorigen in context.Cat_Estado on oferta.Estado_Origen equals estadoorigen.id
                             join ciudadorigen in context.Cat_Ciudad on oferta.ciudad_Origen equals ciudadorigen.id
                             join regionorigen in context.Cat_Region on oferta.Region_Origen equals regionorigen.id
                             join estadodestino in context.Cat_Estado on oferta.Estado_Origen equals estadodestino.id
                             join ciudaddestino in context.Cat_Ciudad on oferta.ciudad_Origen equals ciudaddestino.id
                             join regiondestino in context.Cat_Region on oferta.Region_Origen equals regiondestino.id
                             join tipounidad in context.Cat_Tipos_Unidades on oferta.Tipo_De_Unidad equals tipounidad.id
                             join transportista in context.Transportista on oferta.Transportista equals transportista.id
                             select new ofertas
                             {
                                 estadoorigen = estadoorigen.nombre,
                                 idestadoorigen = estadoorigen.id,
                                 idestadodestino = estadodestino.id,
                                 idciudadorigen = ciudadorigen.id,
                                 idciudaddestino = ciudaddestino.id,
                                 ciudadorigen = ciudadorigen.nombre,
                                 ciudaddestino = ciudaddestino.nombre,
                                 estadodestino = estadodestino.nombre,
                                 tipounidad = tipounidad.nombre,
                                 idtipounidad = tipounidad.id,
                                 fechadisponibilidad = oferta.Fecha_Disponibilidad,
                                 transportista = transportista.NivelServicio,
                                 idtransportista = transportista.id,
                                 estatus = oferta.status
                             }).ToList().AsQueryable();

                if(busqueda.idestadoorigen != 0)
                {
                    queryable = queryable.Where(x => x.idestadoorigen == busqueda.idestadoorigen);
                }
                if(busqueda.idestadodestino != 0)
                {
                    queryable = queryable.Where(x => x.idestadodestino == busqueda.idestadodestino);
                }
                if(busqueda.idciudadorigen != 0)
                {
                    queryable = queryable.Where(x => x.idciudadorigen == busqueda.idciudadorigen);
                }
                if(busqueda.idciudaddestino != 0)
                {
                    queryable = queryable.Where(x => x.idciudaddestino == busqueda.idciudaddestino);
                }
                if(busqueda.idtipounidad != 0)
                {
                    queryable = queryable.Where(x => x.idtipounidad == busqueda.idtipounidad);
                }
                if(busqueda.transportista != 0)
                {
                    queryable = queryable.Where(x => x.transportista == busqueda.transportista);
                }
                if(busqueda.fechadisponibilidad != "" && busqueda.fechadisponibilidad != null)
                {
                    queryable = queryable.Where(x => x.fechadisponibilidad.Contains(busqueda.fechadisponibilidad.ToString()));
                }

                return Ok(queryable);
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
            public int idtipounidad { get; set; }
            public string estadoorigen { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public string estadodestino { get; set; }
            public string tipounidad { get; set; }
            public string fechadisponibilidad { get; set; }
            public int transportista { get; set; }
            public int estatus { get; set; }
            public int idtransportista { get; set; }
        }



    [Route("setCarga")]
        public ActionResult setUpdate([FromBody] Carga cModel)
        {
            foreach (var item in cModel.catCarga)
            {
                var dato_ = new Oferta {
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
                    Nivel_Destino = item.Nivel_Destino,
                    Region_Destino = item.Region_Destino,
                    estado_Destino = item.estado_Destino,
                    ciudad_Destino = item.ciudad_Destino,
                    Tolerancia_Destino = item.Tolerancia_Destino,
                };
                context.Oferta.Add(dato_);
                context.SaveChanges();
            }
            return Ok();
        }
    }
}

