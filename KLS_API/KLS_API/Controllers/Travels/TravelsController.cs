using KLS_API.Context;
using KLS_API.Models.Travels;
using Microsoft.AspNetCore.Mvc;
using KLS_API.Models.DTO;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using KLS_API.Models;
using KLS_API.Models.Clients;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;

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
                             viajes.MainTravelId,
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

                                      join chofer in _dbContext.Tr_Has_Operadores on serviciodata.IdChofer equals chofer.Id
                                      into choferservicio
                                      from choferdata in choferservicio.DefaultIfEmpty()

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
                                          viajes.StatusUpdated,
                                          clientedata.Ejecutivo,
                                          viajes.CreatedBy,
                                          ChoferNombre = choferdata.nombre,
                                          ChoferTelefono = choferdata.NoTelefono
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
                                 join chofer in _dbContext.Tr_Has_Operadores on servicio.IdChofer equals chofer.Id
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
                                     viajes.StatusUpdated,
                                     cliente.Ejecutivo,
                                     viajes.CreatedBy,
                                     ChoferNombre = chofer.nombre,
                                     ChoferTelefono = chofer.NoTelefono
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
                travel.NombreCliente = _dbContext.Clientes.FirstOrDefault(x => x.id == travel.IdCliente).NombreCorto;
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

        [HttpGet("[action]/{TravelId}")]
        public IActionResult CartaPorte(int TravelId)
        {
            try
            {
                CartaPorteModel cartaPorte = _dbContext.Servicios.Where(x => x.TravelId == TravelId).Select(x => new CartaPorteModel
                {
                    FolioFacturacion = x.Travel.Folio,
                    Fecha = DateTime.Now.ToString("d"),
                    Lugar = "Monterrey",
                    Ruta = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == _dbContext.Ruta.FirstOrDefault(y => y.id == x.Travel.IdRuta).id_estadoorigen).nombre, ", ",
                    _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == _dbContext.Ruta.FirstOrDefault(y => y.id == x.Travel.IdRuta).id_ciudadorigen).nombre, " - ",
                    _dbContext.Cat_Estado.FirstOrDefault(y => y.id == _dbContext.Ruta.FirstOrDefault(y => y.id == x.Travel.IdRuta).id_estadodestino).nombre, ", ",
                    _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == _dbContext.Ruta.FirstOrDefault(y => y.id == x.Travel.IdRuta).id_ciudaddestino).nombre),
                    Ejecutivo = _dbContext.Clientes.FirstOrDefault(y => y.id == x.Travel.IdCliente).Ejecutivo,
                    Origen = string.Concat(
                        _dbContext.Cl_Has_Origen.Where(y => y.Id == x.Travel.IdOrigen).Select(y => string.Concat(y.Direccion, ", ", y.Cp, ", ",
                        _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == x.Travel.IdOrigen).Id_Ciudad).nombre, ", ",
                        _dbContext.Cat_Estado.FirstOrDefault(y => y.id == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == x.Travel.IdOrigen).Id_Estado).nombre))
                    ),
                    Destino = string.Concat(
                        _dbContext.Cl_Has_Destinos.Where(y => y.Id == x.Travel.IdDestino).Select(y => string.Concat(y.Direccion, ", ", y.Cp, ", ",
                        _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == _dbContext.Cl_Has_Destinos.FirstOrDefault(y => y.Id == x.Travel.IdDestino).Id_Ciudad).nombre, ", ",
                        _dbContext.Cat_Estado.FirstOrDefault(y => y.id == _dbContext.Cl_Has_Destinos.FirstOrDefault(y => y.Id == x.Travel.IdDestino).Id_Estado).nombre))
                    ),
                    Transportistas = _dbContext.Transportista.Where(y => y.id == x.IdTransportista).Select(y => new CartaPorteModel.TransportistaModel
                    {
                        Nombre = _dbContext.Transportista.FirstOrDefault(y => y.id == x.IdTransportista).NombreComercial,
                        Direccion = _dbContext.Transportista.FirstOrDefault(y => y.id == x.IdTransportista).DireccionOficinas
                    }).ToList(),
                    Pedido = new string[] { x.Travel.ReferenciaUno, x.Travel.ReferenciaDos, x.Travel.ReferenciaTres },
                    Unidades = _dbContext.Unidades.Where(y => y.ServicesId == x.Id).Select(y => new CartaPorteModel.UnidadModel
                    {
                        Nombre = _dbContext.Tr_Has_Inventario.FirstOrDefault(z => z.Id == y.IdUnidad).Marca,
                        Placas = _dbContext.Tr_Has_Inventario.FirstOrDefault(z => z.Id == y.IdUnidad).Placa,
                        Operador = _dbContext.Tr_Has_Operadores.FirstOrDefault(z => z.Id == y.IdUnidad).nombre
                    }).ToList(),
                    CitaCarga = DateTime.Now,
                    CitaDescarga = DateTime.Now
                }).FirstOrDefault();

                return Ok(cartaPorte);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        public class SearchRuta
        {
            public int Id { get; set; }
            public string OD { get; set; }
            public int OrigenId { get; set; }
            public int DestinoId { get; set; }
        }

        [HttpPost("[action]")]
        public IActionResult GetRuta([FromBody] SearchRuta search)
        {
            try
            {
                //List<SearchRuta> routes = _dbContext.Ruta.Where(x => x.id_ciudadorigen == _dbContext.Cl_Has_Origen.Find(search.OrigenId).Id_Ciudad && x.id_ciudaddestino == _dbContext.Cl_Has_Destinos.Find(search.DestinoId).Id_Ciudad).Select(x => new SearchRuta
                List<SearchRuta> routes = _dbContext.Ruta.Where(x => x.id_ciudadorigen == _dbContext.Cl_Has_Origen.Find(search.OrigenId).Id_Ciudad && x.id_ciudaddestino == _dbContext.Cl_Has_Destinos.Find(search.DestinoId).Id_Ciudad).Select(x => new SearchRuta
                {
                    Id = x.id,
                    OD = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadoorigen).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudadorigen).nombre, " - ", _dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadodestino).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudaddestino).nombre)
                })
                .ToList();
                return Ok(routes);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        public class RoutePrice
        {
            public decimal Minimo { get; set; }
            public decimal Maximo { get; set; }
        }

        [HttpGet("[action]/{RouteId}")]
        public IActionResult GetRoutePrice(int RouteId)
        {
            try
            {
                return Ok(_dbContext.Ruta.Where(x => x.id == RouteId).Select(x => new RoutePrice
                {
                    Minimo = x.PrecioMinimo,
                    Maximo = x.PrecioMaximo
                }).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpGet("[action]/{MainTravelId}")]
        public IActionResult GetMainTravel(int MainTravelId)
        {
            try
            {
                MainTravel mainTravel = _dbContext.MainTravels.Where(x => x.Id == MainTravelId).Select(x => new MainTravel
                {
                    Id = x.Id,
                    ServiceId = x.ServiceId,
                    Ejecutivo = x.Ejecutivo,
                    GrupoMonitor = x.GrupoMonitor,
                    CreatedBy = x.CreatedBy,
                    UpdatedBy = x.UpdatedBy,
                    TimeCreated = x.TimeCreated,
                    TimeUpdated = x.TimeUpdated,
                    FechaLlegada = x.FechaLlegada,
                    FechaSalida = x.FechaSalida,
                    Folio = x.Folio,
                    Status = x.Status,
                    Subestatus = x.Subestatus,
                    Travels = _dbContext.Viajes.Where(y => y.MainTravelId == x.Id)
                }).FirstOrDefault();

                if (MainTravelId > 0 && mainTravel is null)
                {
                    return NotFound(mainTravel);
                }

                return Ok(mainTravel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost("[action]")]
        public IActionResult SetMainTravel([FromBody] MainTravel model)
        {
            try
            {
                model.Status = "registrado";
                model.TimeCreated = DateTime.Now;
                _dbContext.MainTravels.Add(model);
                _dbContext.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("[action]")]
        public IActionResult GetTipoServicio()
        {
            try
            {
                var unidades = _dbContext.Cat_Tipos_Unidades.Where(x => x.estatus == 1);
                return Ok(unidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("[action]/{TramoId}")]
        public IActionResult GetTramo(int TramoId)
        {
            try
            {
                Travel travel = new Travel();
                travel = _dbContext.Viajes.FirstOrDefault(x => x.Id == TramoId);

                if (TramoId > 0 && travel is null)
                {
                    return NotFound();
                }

                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("[action]")]
        public IActionResult GetCustomers()
        {
            try
            {
                IEnumerable<Clientes> customers = _dbContext.Clientes.Where(x => x.Estatus == 1);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("[action]/{MainTravelId}")]
        public IActionResult CountTramos(int MainTravelId)
        {
            try
            {
                int counter = _dbContext.Viajes.Count(x => x.MainTravelId == MainTravelId);
                return Ok(counter);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("[action]/{TramoId}")]
        public IActionResult TruncateTramo(int TramoId)
        {
            try
            {
                var services = _dbContext.Servicios.Where(x => x.TravelId == TramoId).ToList();

                if (services.Any())
                {
                    foreach (var service in services)
                    {
                        int serviceId = service.Id;
                        var units = _dbContext.Unidades.Where(x => x.ServicesId == serviceId).ToList();
                        foreach (var unit in units)
                        {
                            _dbContext.Unidades.Remove(unit);
                        }
                        _dbContext.Remove(service);
                    }
                    //var tramo = _dbContext.Viajes.Find(TramoId);
                    //_dbContext.Viajes.Remove(tramo);
                    _dbContext.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("[action]")]
        public IActionResult UpdateViaje(Travel travel)
        {
            try
            {
                _dbContext.Entry(travel).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPatch]
        [Route("[action]/{TramoId}")]
        public IActionResult PatchTramo(int TramoId, [FromBody] JsonPatchDocument<Travel> patchDoc)
        {
            var route = _dbContext.Viajes.Find(TramoId);
            if (route == null)
            {
                return NotFound();
            }
            if (patchDoc == null)
            {
                return BadRequest();
            }

            patchDoc.ApplyTo(route);

            _dbContext.SaveChanges();
            return Ok(route);
        }
    }
}
