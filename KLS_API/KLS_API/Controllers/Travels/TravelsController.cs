using KLS_API.Context;
using KLS_API.Models.Travels;
using Microsoft.AspNetCore.Mvc;
using KLS_API.Models.DTO;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

        [HttpGet("[action]/{id}")]
        public IActionResult GetServicios(int id)
        {
            try
            {
                var servicios = _dbContext.Servicios.Where(x => x.TravelId == id).Select(x => new Services
                {
                    Id = x.Id,
                    TravelId = x.TravelId,
                    Nombre = x.Nombre,
                    IdTransportista = x.IdTransportista,
                    IdChofer = x.IdChofer,
                    Costo = x.Costo,
                    Precio = x.Precio,
                    IdNaviera = x.IdNaviera,
                    Buque = x.Buque,
                    IdAgenteAduanal = x.IdAgenteAduanal,
                    IdContactoAA = x.IdContactoAA,
                    IdAerolinea = x.IdAerolinea,
                    IdContactoA = x.IdContactoA,
                    IdCoLoader = x.IdCoLoader,
                    IdContactoCL = x.IdContactoCL,
                    Unidades = x.Unidades.Where(x => x.ServicesId == x.Services.Id).ToList()
                }).ToList();

                return Ok(servicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
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
                                      where viajes.Id == id

                                      join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                                      into viajecliente
                                      from clientedata in viajecliente.DefaultIfEmpty()

                                      join ciudadorigen in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudadorigen.id
                                      join estadoorigen in _dbContext.Cat_Estado on ciudadorigen.id_estado equals estadoorigen.id
                                      join ciudaddestino in _dbContext.Cat_Ciudad on viajes.IdDestino equals ciudaddestino.id
                                      join estadodestino in _dbContext.Cat_Estado on ciudaddestino.id_estado equals estadodestino.id
                                      join ruta in _dbContext.Ruta on viajes.IdRuta equals ruta.id

                                      join servicio in _dbContext.Servicios on viajes.Id equals servicio.TravelId
                                      into viajeservicio
                                      from serviciodata in viajeservicio.DefaultIfEmpty()

                                      join unidad in _dbContext.Unidades on serviciodata.Id equals unidad.ServicesId
                                      into unidadservicio
                                      from unidaddata in unidadservicio.DefaultIfEmpty()

                                      join unidadt in _dbContext.Cat_Tipos_Unidades on viajes.IdUnidad equals unidadt.id

                                      select new
                                      {
                                          viajes.Id,
                                          viajes.Folio,
                                          clienteid = clientedata.id,
                                          nombrecliente = clientedata.NombreCorto,
                                          viajes.DireccionRemitente,
                                          viajes.DireccionDestinatario,
                                          nombreruta = string.Concat(estadoorigen.nombre, " - ", estadodestino.nombre),
                                          ruta.tiemporuta,
                                          viajes.FechaSalida,
                                          viajes.FechaLlegada,
                                          viajes.CostoTotal,
                                          preciototal = viajes.PrecioClienteTotal,
                                          tipounidadnombre = unidadt.nombre,
                                          Transportista = serviciodata.IdTransportista,
                                          viajes.Estatus,
                                          viajes.SubEstatus,
                                          viajes.StatusUpdated
                                      }).FirstOrDefault() : (
                                 from viajes in _dbContext.Viajes
                                 join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                                 join ciudadorigen in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudadorigen.id
                                 join estadoorigen in _dbContext.Cat_Estado on ciudadorigen.id_estado equals estadoorigen.id
                                 join ciudaddestino in _dbContext.Cat_Ciudad on viajes.IdDestino equals ciudaddestino.id
                                 join estadodestino in _dbContext.Cat_Estado on ciudaddestino.id_estado equals estadodestino.id
                                 join ruta in _dbContext.Ruta on viajes.IdRuta equals ruta.id
                                 join unidad in _dbContext.Cat_Tipos_Unidades on viajes.IdUnidad equals unidad.id
                                 join servicio in _dbContext.Servicios on viajes.Id equals servicio.TravelId
                                 select new
                                 {
                                     viajes.Id,
                                     viajes.Folio,
                                     clienteid = cliente.id,
                                     nombrecliente = cliente.NombreCorto,
                                     viajes.DireccionRemitente,
                                     viajes.DireccionDestinatario,
                                     nombreruta = string.Concat(estadoorigen.nombre, " - ", estadodestino.nombre),
                                     ruta.tiemporuta,
                                     viajes.FechaSalida,
                                     viajes.FechaLlegada,
                                     viajes.CostoTotal,
                                     preciototal = viajes.PrecioClienteTotal,
                                     tipounidadnombre = unidad.nombre,
                                     Transportista = servicio.IdTransportista,
                                     viajes.Estatus,
                                     viajes.SubEstatus,
                                     viajes.StatusUpdated
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
                travel.StatusUpdated = DateTime.Now;
                _dbContext.Viajes.Add(travel);
                _dbContext.SaveChanges();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetMercancia(int id)
        {
            try
            {
                return Ok(_dbContext.Mercancias.OrderBy(x => x.Id).LastOrDefault(x => x.TravelId == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult PostMercancia([FromBody] Mercancia mercancia)
        {
            try
            {
                _dbContext.Mercancias.Add(mercancia);
                _dbContext.SaveChanges();
                return Ok(mercancia);
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

        [HttpDelete("[action]/{ServiceId}")]
        public IActionResult DeleteService(int ServiceId)
        {
            try
            {
                Services service = _dbContext.Servicios.Find(ServiceId);
                if (service is null)
                    return NotFound();
                _dbContext.Remove(service);
                _dbContext.SaveChanges();

                return Ok(service);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("[action]")]
        public IActionResult UpdateStatus([FromBody] Travel model)
        {
            try
            {
                Travel travel = _dbContext.Viajes.Find(model.Id);
                travel.Estatus = model.Estatus;
                travel.SubEstatus = model.SubEstatus;
                travel.StatusUpdated = DateTime.Now;

                _dbContext.SaveChanges();

                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult SetHistorial([FromBody] Historial historial)
        {
            try
            {
                _dbContext.Historial.Add(historial);
                _dbContext.SaveChanges();

                return Ok(historial);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("[action]/{TravelId}")]
        public IActionResult GetHistorial(int TravelId)
        {
            try
            {
                List<Historial> historial = _dbContext.Historial.Where(x => x.TravelId == TravelId).ToList();
                return Ok(historial);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
