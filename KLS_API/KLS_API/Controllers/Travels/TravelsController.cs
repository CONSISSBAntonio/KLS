using KLS_API.Context;
using KLS_API.Models.Travels;
using Microsoft.AspNetCore.Mvc;
using KLS_API.Models.DTO;
using System;
using System.Linq;

namespace KLS_API.Controllers.Travels
{
    [Route("[controller]")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TravelsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetTravels()
        {
            try
            {
                var dt = from viajes in _dbContext.Viajes
                         join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                         join ciudadorigen in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudadorigen.id
                         join estadoorigen in _dbContext.Cat_Estado on ciudadorigen.id_estado equals estadoorigen.id
                         join ciudaddestino in _dbContext.Cat_Ciudad on viajes.IdDestino equals ciudaddestino.id
                         join estadodestino in _dbContext.Cat_Estado on ciudaddestino.id_estado equals estadodestino.id
                         select new
                         {
                             viajes.Id,
                             viajes.Folio,
                             cliente = cliente.NombreCorto,
                             origen = string.Concat(estadoorigen.nombre, "-", ciudadorigen.nombre),
                             destino = string.Concat(estadodestino.nombre, "-", ciudaddestino.nombre),
                             viajes.FechaSalida,
                             viajes.FechaLlegada,
                             viajes.Estatus
                         };
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetTravel(int id)
        {
            try
            {
                var viaje = id > 0 ? (from viajes in _dbContext.Viajes
                                      join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                                      join ciudadorigen in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudadorigen.id
                                      join estadoorigen in _dbContext.Cat_Estado on ciudadorigen.id_estado equals estadoorigen.id
                                      join ciudaddestino in _dbContext.Cat_Ciudad on viajes.IdDestino equals ciudaddestino.id
                                      join estadodestino in _dbContext.Cat_Estado on ciudaddestino.id_estado equals estadodestino.id
                                      join unidad in _dbContext.Cat_Tipos_Unidades on viajes.IdUnidad equals unidad.id
                                      join servicio in _dbContext.Servicios on viajes.Id equals servicio.TravelId
                                      where viajes.Id == id
                                      select new
                                      {
                                          viajes.Id,
                                          viajes.Folio,
                                          nombrecliente = cliente.NombreCorto,
                                          viajes.DireccionRemitente,
                                          viajes.DireccionDestinatario,
                                          nombreruta = string.Concat(estadoorigen.nombre, " - ", estadodestino.nombre),
                                          viajes.FechaSalida,
                                          viajes.FechaLlegada,
                                          viajes.CostoTotal,
                                          preciototal = viajes.PrecioClienteTotal,
                                          tipounidadnombre = unidad.nombre,
                                          Transportista = servicio.IdTransportista
                                      }).FirstOrDefault() :
                                      (from viajes in _dbContext.Viajes
                                       join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                                       join ciudadorigen in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudadorigen.id
                                       join estadoorigen in _dbContext.Cat_Estado on ciudadorigen.id_estado equals estadoorigen.id
                                       join ciudaddestino in _dbContext.Cat_Ciudad on viajes.IdDestino equals ciudaddestino.id
                                       join estadodestino in _dbContext.Cat_Estado on ciudaddestino.id_estado equals estadodestino.id
                                       join unidad in _dbContext.Cat_Tipos_Unidades on viajes.IdUnidad equals unidad.id
                                       join servicio in _dbContext.Servicios on viajes.Id equals servicio.TravelId
                                       select new
                                       {
                                           viajes.Id,
                                           viajes.Folio,
                                           nombrecliente = cliente.NombreCorto,
                                           viajes.DireccionRemitente,
                                           viajes.DireccionDestinatario,
                                           nombreruta = string.Concat(estadoorigen.nombre, " - ", estadodestino.nombre),
                                           viajes.FechaSalida,
                                           viajes.FechaLlegada,
                                           viajes.CostoTotal,
                                           preciototal = viajes.PrecioClienteTotal,
                                           tipounidadnombre = unidad.nombre,
                                           Transportista = servicio.IdTransportista
                                       }).OrderByDescending(x => x.Id).FirstOrDefault();
                return Ok(viaje);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Travel travel)
        {
            try
            {
                _dbContext.Viajes.Add(travel);
                _dbContext.SaveChanges();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult PostService([FromBody] Services service)
        {
            try
            {
                _dbContext.Servicios.Add(service);
                _dbContext.SaveChanges();
                return Ok(service);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult PostUnit([FromBody] Unidad unidad)
        {
            try
            {
                _dbContext.Unidades.Add(unidad);
                _dbContext.SaveChanges();
                return Ok(unidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
