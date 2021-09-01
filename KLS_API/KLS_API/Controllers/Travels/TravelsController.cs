﻿using KLS_API.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using KLS_API.Models;
using Microsoft.EntityFrameworkCore;
using KLS_API.Models.Travel;
using KLS_API.Models.Clients;
using KLS_API.Models.Travel.DTO;
using KLS_API.Models.Carriers;
using KLS_API.Models.DT;

namespace KLS_API.Controllers.Travels
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TravelsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region SelectList
        [HttpGet]
        public async Task<IActionResult> GetTiposUnidades()
        {
            try
            {
                ICollection<Cat_Tipos_Unidades> cat_Tipos_Unidades = await _dbContext.Cat_Tipos_Unidades.Where(x => x.estatus == 1).ToListAsync();
                return Ok(cat_Tipos_Unidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetTravelServices()
        {
            try
            {
                ICollection<TravelService> travelServices = await _dbContext.TravelServices.Where(x => x.Active).ToListAsync();
                return Ok(travelServices);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                ICollection<Clientes> customers = await _dbContext.Clientes.Where(x => x.Estatus == 1).ToListAsync();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSectionType()
        {
            try
            {
                ICollection<SectionType> sectionTypes = await _dbContext.SectionTypes.Where(x => x.Active).ToListAsync();
                return Ok(sectionTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCarriers()
        {
            try
            {
                ICollection<Transportista> carriers = await _dbContext.Transportista.Where(x => x.Estatus == 1).ToListAsync();
                return Ok(carriers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        #endregion

        #region Travel
        [HttpGet("{TravelId}")]
        public async Task<IActionResult> GetTravel(int TravelId)
        {
            try
            {
                Travel travel = await _dbContext.Travels.Include(x => x.Sections).ThenInclude(y => y.Services).Include(x => x.Sections).ThenInclude(x => x.Clients).SingleOrDefaultAsync(x => x.Id == TravelId);

                if (travel is null)
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

        [HttpPost]
        public async Task<IActionResult> PostTravel(Travel travel)
        {
            try
            {
                int status = _dbContext.Statuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                int substatus = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                int lastid = _dbContext.Travels.Count() + 1;

                travel.Folio = string.Concat("V-", DateTime.Now.ToString("yyMM"), lastid.ToString("D4"));
                travel.SubstatusId = substatus;

                await _dbContext.Travels.AddAsync(travel);
                await _dbContext.SaveChangesAsync();

                return Ok(travel.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutTravel(Travel travel)
        {
            try
            {
                _dbContext.Entry(travel).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        #endregion

        #region Section
        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetSection(int SectionId)
        {
            try
            {

                Section section = await _dbContext.Sections.Include(x => x.Services).ThenInclude(x => x.Units).Where(x => x.Id == SectionId).Include(x => x.Services).ThenInclude(x => x.ServiceType).SingleOrDefaultAsync();
                if (section is null)
                {
                    return NotFound();
                }
                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetCustomerOD(int CustomerId)
        {
            try
            {
                CustomerOD customerOD = new CustomerOD
                {
                    Origins = await _dbContext.Cl_Has_Origen.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).ToListAsync(),
                    Destinations = await _dbContext.Cl_Has_Destinos.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).ToListAsync()
                };
                return Ok(customerOD);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> PostSection(Section section)
        {
            try
            {
                Travel travel = await _dbContext.Travels.FindAsync(section.TravelId);
                SectionType sectionType = await _dbContext.SectionTypes.FindAsync(section.SectionTypeId);
                if (travel is null || sectionType is null)
                {
                    return BadRequest();
                }

                if (section.IsEmpty)
                {
                    section.ClientesId = null;
                    section.Cl_Has_OrigenId = null;
                    section.Cl_Has_DestinosId = null;
                    section.Cl_Has_OtrosId = null;
                }

                int lastid = _dbContext.Sections.Where(x => x.TravelId == section.TravelId && x.Active).Count() + 1;

                section.Folio = string.Concat(sectionType.Acronym, DateTime.Now.ToString("yyMM"), travel.Folio.Substring(travel.Folio.Length - 4), "-", lastid.ToString("D2"));
                section.SubstatusId = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                if (!section.IsEmpty)
                {
                    section.Cl_Has_OtrosId = _dbContext.Cl_Has_Otros.FirstOrDefault(x => x.Id_Cliente == section.ClientesId).Id;
                }

                await _dbContext.Sections.AddAsync(section);
                await _dbContext.SaveChangesAsync();

                return Ok(section.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutSection(Section model)
        {
            try
            {
                model.SubstatusId = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                if (!model.IsEmpty)
                {
                    model.Cl_Has_OtrosId = _dbContext.Cl_Has_Otros.FirstOrDefault(x => x.Id_Cliente == model.ClientesId).Id;
                }
                model.TimeUpdated = DateTime.Now;
                _dbContext.Entry(model).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return Ok(model.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{SectionId}")]
        public async Task<IActionResult> DeleteSection(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections.FindAsync(SectionId);
                if (section is null)
                {
                    return NotFound();
                }
                _dbContext.Sections.Remove(section);
                await _dbContext.SaveChangesAsync();
                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{ClientId}")]
        public async Task<IActionResult> GetClientReferences(int ClientId)
        {
            try
            {
                Cl_Has_Otros cl_Has_Otros = await _dbContext.Cl_Has_Otros.SingleOrDefaultAsync(x => x.Id_Cliente == ClientId);
                if (cl_Has_Otros is null)
                {
                    return NotFound();
                }
                return Ok(cl_Has_Otros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetKLSRoutes()
        {
            try
            {
                ICollection<RouteKLSDTO> travels = await _dbContext.Ruta.Where(x => x.estatus == 1).Select(x => new RouteKLSDTO
                {
                    Id = x.id,
                    OD = string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.id_estadoorigen).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.id_ciudadorigen).nombre, "-", _dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.id_estadodestino).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.id_ciudaddestino).nombre)
                }).ToListAsync();
                return Ok(travels);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetCustomerRequirements(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections.FindAsync(SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                Cl_Has_Requisitos cl_Has_Requisitos = await _dbContext.Cl_Has_Requisitos.SingleOrDefaultAsync(x => x.Id_Cliente == section.ClientesId);
                if (cl_Has_Requisitos is null)
                {
                    return NotFound();
                }
                return Ok(cl_Has_Requisitos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetCustomerBox(int SectionId)
        {
            try
            {
                BoxDTO box = await _dbContext.Sections.Where(x => x.Id == SectionId).Select(x => new BoxDTO
                {
                    SectionId = x.Id,
                    Alto = x.Alto,
                    Ancho = x.Ancho,
                    Largo = x.Largo,
                    Peso = x.Peso,
                    PesoVolumetrico = x.PesoVolumetrico,
                    Cl_Has_Box = _dbContext.Cl_Has_Box.SingleOrDefault(y => y.Id_Cliente == x.ClientesId)
                }).SingleOrDefaultAsync();

                if (box is null)
                {
                    return NotFound();
                }
                return Ok(box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        #endregion

        #region Services
        public class ServicesModel
        {
            public int ServiceId { get; set; }
            public int SectionId { get; set; }
            public string Service { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public int CarrierId { get; set; }
            public int DriverId { get; set; }
            public List<Unidad> Units { get; set; }
            public class Unidad
            {
                public int Id { get; set; }
                public int TypeId { get; set; }
                public int UnitId { get; set; }
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEditServices(ServicesModel model)
        {
            try
            {
                ServiceType serviceType = await _dbContext.ServiceTypes.SingleOrDefaultAsync(x => x.Name.ToLower().Replace(" ", "") == model.Service);
                if (serviceType is null)
                {
                    return BadRequest();
                }

                Section section = await _dbContext.Sections.FindAsync(model.SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                Service service = new Service { SectionId = section.Id, ServiceTypeId = serviceType.Id };

                if (model.ServiceId != -1)
                {
                    service = await _dbContext.Services.FindAsync(model.ServiceId);
                    if (service is null)
                    {
                        return NotFound();
                    }

                    service.TransportistaId = model.CarrierId;
                    service.Tr_Has_OperadoresId = model.DriverId;
                    service.Costo = model.Cost;
                    service.Precio = model.Price;
                    service.TimeUpdated = DateTime.Now;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    service = new Service
                    {
                        SectionId = model.SectionId,
                        TransportistaId = model.CarrierId,
                        Tr_Has_OperadoresId = model.DriverId,
                        Costo = model.Cost,
                        Precio = model.Price,
                        ServiceTypeId = serviceType.Id
                    };
                    await _dbContext.Services.AddAsync(service);
                    await _dbContext.SaveChangesAsync();
                }



                foreach (var unitmodel in model.Units)
                {
                    Unit unit = new Unit { ServiceId = service.Id };
                    if (unitmodel.Id != -1)
                    {
                        unit = await _dbContext.Units.FindAsync(unit.Id);
                        if (unit is null)
                        {
                            continue;
                        }
                        unit.Cat_Tipos_UnidadesId = unitmodel.TypeId;
                        unit.Tr_Has_InventarioId = unitmodel.UnitId;
                        unit.TimeUpdated = DateTime.Now;
                        await _dbContext.SaveChangesAsync();
                    }
                    else
                    {
                        unit.Cat_Tipos_UnidadesId = unitmodel.TypeId;
                        unit.Tr_Has_InventarioId = unitmodel.UnitId;
                        unit.TimeCreated = DateTime.Now;

                        await _dbContext.Units.AddAsync(unit);
                    }
                }

                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{ServiceId}")]
        public async Task<IActionResult> DeleteService(int ServiceId)
        {
            try
            {
                Service service = await _dbContext.Services.FindAsync(ServiceId);
                if (service is null)
                {
                    return NotFound();
                }
                _dbContext.Services.Remove(service);
                await _dbContext.SaveChangesAsync();
                return Ok(service);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{UnitId}")]
        public async Task<IActionResult> DeleteUnit(int UnitId)
        {
            try
            {
                Unit unit = await _dbContext.Units.FindAsync(UnitId);
                if (unit is null)
                {
                    return NotFound();
                }

                _dbContext.Units.Remove(unit);
                await _dbContext.SaveChangesAsync();
                return Ok(unit);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        #endregion
        public class SearchRuta
        {
            public int Id { get; set; }
            public string OD { get; set; }
            public int OriginId { get; set; }
            public int DestinationId { get; set; }
        }

        [HttpPost]
        public IActionResult GetRoute([FromBody] SearchRuta search)
        {
            try
            {
                List<SearchRuta> routes = _dbContext.Ruta.Where(x => x.id_ciudadorigen == _dbContext.Cl_Has_Origen.Find(search.OriginId).Id_Ciudad && x.id_ciudaddestino == _dbContext.Cl_Has_Destinos.Find(search.DestinationId).Id_Ciudad).Select(x => new SearchRuta
                {
                    Id = x.id,
                    OD = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadoorigen).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudadorigen).nombre, " - ", _dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadodestino).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudaddestino).nombre)
                }).ToList();
                return Ok(routes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpGet("{Type}/{Id}")]
        public IActionResult GetAddress(string Type, int Id)
        {
            try
            {
                if (Id == 0)
                {
                    return NotFound();
                }

                string address = string.Empty;

                if (Type == "origin")
                {
                    address = _dbContext.Cl_Has_Origen.Find(Id).Direccion;
                    return Ok(address);
                }

                address = _dbContext.Cl_Has_Destinos.Find(Id).Direccion;
                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        #region DataTableTravels
        [HttpPost]
        public async Task<IActionResult> DataTableTravels(DTParams dtParams)
        {
            try
            {
                IEnumerable<TravelDT> sections = await _dbContext.Sections.Where(x => x.Active && x.FechaSalida > DateTime.Now).Select(x => new TravelDT
                {
                    Id = x.Id,
                    MainTravelId = x.TravelId,
                    Folio = x.Folio,
                    Cliente = x.Clients.NombreCorto,
                    Origen = string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Ciudad).nombre),
                    Destino = string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Ciudad).nombre),
                    FechaSalida = x.FechaSalida.ToString("dd/MM/yyyy. hh:mm tt"),
                    FechaLlegada = x.FechaLlegada.ToString("dd/MM/yyyy. hh:mm tt"),
                    Estatus = x.Substatus.Name
                }).ToListAsync();

                int total = sections.Count();

                if (!string.IsNullOrEmpty(dtParams.search.value[0]))
                {
                    string keyword = dtParams.search.value[0].ToLower();

                    sections = sections.Where(x => x.Folio.ToLower().Contains(keyword) ||
                    x.Cliente.ToLower().Contains(keyword) ||
                    x.Origen.ToLower().Contains(keyword) ||
                    x.Destino.ToLower().Contains(keyword) ||
                    x.FechaSalida.ToLower().Contains(keyword) ||
                    x.FechaLlegada.ToLower().Contains(keyword) ||
                    x.Estatus.ToLower().Contains(keyword));
                }

                long totalFiltered = sections.Count();

                int columnId = dtParams.order[0].column[0];

                Func<TravelDT, string> orderFunction = (x => columnId == 0 ? x.Folio :
                columnId == 1 ? x.Cliente :
                columnId == 2 ? x.Origen :
                columnId == 3 ? x.Destino :
                columnId == 4 ? x.FechaSalida :
                columnId == 5 ? x.FechaLlegada :
                x.Estatus);

                sections = dtParams.order[0].dir[0] == "asc" ? sections.OrderBy(orderFunction) : sections.OrderByDescending(orderFunction);

                sections.Skip(dtParams.start).Take(dtParams.length);

                List<TravelDT> data = sections.ToList();

                return Json(new
                {
                    aaData = data,
                    dtParams.draw,
                    iTotalRecords = total,
                    iTotalDisplayRecords = totalFiltered
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}
