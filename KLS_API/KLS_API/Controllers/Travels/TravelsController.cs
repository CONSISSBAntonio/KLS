using KLS_API.Context;
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
using KLS_API.Models.Demands;
using KLS_API.Models.Oferta;
using System.Collections.ObjectModel;

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
                ICollection<Cat_Tipos_Unidades> cat_Tipos_Unidades = await _dbContext.Cat_Tipos_Unidades.Where(x => x.estatus == 1).OrderBy(x => x.nombre).ToListAsync();
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
                ICollection<TravelService> travelServices = await _dbContext.TravelServices.Where(x => x.Active).OrderBy(x => x.Name).ToListAsync();
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
                ICollection<Clientes> customers = await _dbContext.Clientes.Where(x => x.Estatus == 1).OrderBy(x => x.NombreCorto).ToListAsync();
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
                ICollection<SectionType> sectionTypes = await _dbContext.SectionTypes.Where(x => x.Active).OrderBy(x => x.Name).ToListAsync();
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
                ICollection<Transportista> carriers = await _dbContext.Transportista.Where(x => x.Estatus == 1).OrderBy(x => x.RazonSocial).ToListAsync();
                //ICollection<Transportista> carrierswithdrivers = new Collection<Transportista>();
                //foreach (var carrier in carriers)
                //{
                //    bool hasOperadores = await _dbContext.Tr_Has_Operadores.AnyAsync(x => x.Id_Transportista == carrier.id);
                //    if (hasOperadores)
                //    {
                //        carrierswithdrivers.Add(carrier);
                //    }
                //}
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
                Travel travel = await _dbContext.Travels.Include(x => x.Sections).ThenInclude(y => y.Services).Include(x => x.Sections).ThenInclude(x => x.Clients).Include(x => x.Sections).ThenInclude(x => x.Substatus).ThenInclude(x => x.Status).SingleOrDefaultAsync(x => x.Id == TravelId);

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
        public async Task<IActionResult> PutTravel(Travel model)
        {
            try
            {
                Travel travel = await _dbContext.Travels.FindAsync(model.Id);
                if (travel is null)
                {
                    return NotFound();
                }
                travel.TravelServiceId = model.TravelServiceId;
                travel.Ejecutivo = model.Ejecutivo;
                travel.GrupoMonitor = model.GrupoMonitor;
                travel.TimeUpdated = DateTime.Now;
                await _dbContext.SaveChangesAsync();

                return Ok(travel.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostSectionLog(SectionLog sectionLog)
        {
            try
            {
                await _dbContext.SectionLogs.AddAsync(sectionLog);
                await _dbContext.SaveChangesAsync();
                return Ok(sectionLog);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetSetcionLogs(int SectionId)
        {
            try
            {
                ICollection<SectionLog> sectionLogs = await _dbContext.SectionLogs.Where(x => x.SectionId == SectionId && x.Active).ToListAsync();
                return Ok(sectionLogs);
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
                    Origins = await _dbContext.Cl_Has_Origen.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).OrderBy(x => x.Nombre).ToListAsync(),
                    Destinations = await _dbContext.Cl_Has_Destinos.Where(x => x.Estatus == 1 && x.Id_Cliente == CustomerId).OrderBy(x => x.Nombre).ToListAsync()
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

                SectionType sectionType = await _dbContext.SectionTypes.FindAsync(1);
                //SectionType sectionType = await _dbContext.SectionTypes.FindAsync(section.SectionTypeId);
                if (travel is null || sectionType is null)
                {
                    return BadRequest();
                }
                else
                {
                    section.SectionTypeId = 1;
                }

                if (section.IsEmpty)
                {
                    section.ClientesId = null;
                    section.Cl_Has_OrigenId = null;
                    section.Cl_Has_DestinosId = null;
                    section.Cl_Has_OtrosId = null;
                }

                bool sectionexists = _dbContext.Sections.Any(x => x.TravelId == section.TravelId && x.Active);
                int autoincrement = 1;
                if (sectionexists)
                {
                    Section lastsection = _dbContext.Sections.Where(x => x.TravelId == section.TravelId).ToList().LastOrDefault();
                    autoincrement = Int32.Parse(lastsection.Folio.Split("-")[1]) + 1;
                }

                section.Folio = string.Concat(DateTime.Now.ToString("yyMM"), travel.Folio.Substring(travel.Folio.Length - 4), "-", autoincrement.ToString("D2"));
                //section.Folio = string.Concat(sectionType.Acronym, DateTime.Now.ToString("yyMM"), travel.Folio.Substring(travel.Folio.Length - 4), "-", autoincrement.ToString("D2"));
                section.SubstatusId = _dbContext.Substatuses.FirstOrDefault(x => x.Name.ToLower() == "registrado").Id;
                section.GrupoMonitor = travel.GrupoMonitor;
                section.StatusUpdatedAt = DateTime.Now;

                Cl_Has_Otros cl_Has_Otros = await _dbContext.Cl_Has_Otros.SingleOrDefaultAsync(x => x.Id_Cliente == section.ClientesId);

                if (!section.IsEmpty && cl_Has_Otros != null)
                {
                    section.Cl_Has_OtrosId = cl_Has_Otros.Id;
                }
                else
                {
                    section.Cl_Has_OtrosId = null;
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
                //ESTABLECER TIPO DE SECCION FIJA
                model.SectionTypeId = 1;
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

                Oferta oferta = await _dbContext.Oferta.SingleOrDefaultAsync(x => x.SectionId == SectionId);
                if (oferta != null)
                {
                    _dbContext.Oferta.Remove(oferta);
                }

                var services = await _dbContext.Services.Where(x => x.SectionId == SectionId).ToListAsync();
                foreach (var service in services)
                {
                    var units = await _dbContext.Units.Where(x => x.ServiceId == service.Id).ToListAsync();
                    foreach (var unit in units)
                    {
                        _dbContext.Units.Remove(unit);
                    }
                    _dbContext.Services.Remove(service);
                }

                var sectionComments = await _dbContext.SectionComments.Where(x => x.SectionId == SectionId).ToListAsync();
                foreach (var comment in sectionComments)
                {
                    var evidences = await _dbContext.Evidences.Where(x => x.SectionCommentId == comment.Id).ToListAsync();
                    foreach (var evidence in evidences)
                    {
                        _dbContext.Evidences.Remove(evidence);
                    }
                    _dbContext.SectionComments.Remove(comment);
                }

                await _dbContext.SaveChangesAsync();

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
                IEnumerable<RouteKLSDTO> travels = await _dbContext.Ruta.Where(x => x.estatus == 1).Select(x => new RouteKLSDTO
                {
                    Id = x.id,
                    OD = string.Concat("Origen: ", _dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.id_estadoorigen).nombre.Trim(), ", ", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.id_ciudadorigen).nombre.Trim(), " || Destino: ", _dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.id_estadodestino).nombre.Trim(), ", ", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.id_ciudaddestino).nombre.Trim())
                }).ToListAsync();

                travels = travels.OrderBy(x => x.OD);
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

        [HttpPost]
        public async Task<IActionResult> PostWare(BoxDTO boxDTO)
        {
            try
            {
                Section section = await _dbContext.Sections.FindAsync(boxDTO.SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                section.Alto = boxDTO.Alto;
                section.Ancho = boxDTO.Ancho;
                section.Largo = boxDTO.Largo;
                section.Peso = boxDTO.Peso;
                section.PesoVolumetrico = boxDTO.PesoVolumetrico;
                await _dbContext.SaveChangesAsync();
                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{DemandId}")]
        public async Task<IActionResult> ConvertDemand(int DemandId)
        {
            try
            {
                Demand demand = await _dbContext.Demands.FindAsync(DemandId);
                if (demand is null)
                {
                    return BadRequest();
                }

                Section section = new Section
                {
                    ClientesId = demand.ClientId,
                    Cl_Has_OrigenId = demand.OriginId,
                    Cl_Has_DestinosId = demand.DestinationId,
                    RutaId = demand.RouteId,
                    FechaSalida = demand.FechaDisponibilidad,
                    Anticipacion = demand.Arribo
                };

                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{SectionId}")]
        public async Task<IActionResult> GetSectionComments(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections.Include(x => x.SectionComments).ThenInclude(x => x.Evidences).Include(x => x.Substatus).Include(x => x.SectionComments).ThenInclude(x => x.Substatus).ThenInclude(x => x.Status).SingleOrDefaultAsync(x => x.Active && x.Id == SectionId);
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

        [HttpPut("{OfferId}")]
        public async Task<IActionResult> UpdateOfferConverted(int OfferId)
        {
            try
            {
                Oferta oferta = await _dbContext.Oferta.FindAsync(OfferId);
                if (oferta is null)
                {
                    return NotFound();
                }
                oferta.status = 3;
                await _dbContext.SaveChangesAsync();
                return Ok(oferta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("{DemandId}")]
        public async Task<IActionResult> UpdateDemandConverted(int DemandId)
        {
            try
            {
                Demand demand = await _dbContext.Demands.FindAsync(DemandId);
                if (demand is null)
                {
                    return NotFound();
                }

                demand.Status = "convertida a viaje";
                demand.TimeUpdated = DateTime.Now;
                await _dbContext.SaveChangesAsync();
                return Ok(demand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost("{SectionId}")]
        public async Task<IActionResult> CreateOffer(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections.Include(x => x.Ruta).Include(x => x.Services).SingleOrDefaultAsync(x => x.Id == SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                Travel travel = await _dbContext.Travels.FindAsync(section.TravelId);
                if (travel is null)
                {
                    return NotFound();
                }

                if (section.SubstatusId == 5)
                {
                    Oferta oferta = await _dbContext.Oferta.SingleOrDefaultAsync(x => x.SectionId == section.Id);

                    if (oferta is null)
                    {
                        int carrierId = section.Services.FirstOrDefault(x => x.Active).TransportistaId;

                        Oferta newoferta = new Oferta
                        {
                            Transportista = carrierId,
                            Tipo_De_Unidad = 0,
                            Cantidad = 1,
                            Fecha_Disponibilidad = section.FechaLlegada,
                            Rango_De_Espera = 0,
                            Nivel_Origen = "Ciudad",
                            Region_Origen = 0,
                            Estado_Origen = section.Ruta.id_estadoorigen,
                            ciudad_Origen = section.Ruta.id_ciudadorigen,
                            Tolerancia_Origen = 0,
                            Nivel_Destino = "Ciudad",
                            Region_Destino = 0,
                            estado_Destino = section.Ruta.id_estadodestino,
                            ciudad_Destino = section.Ruta.id_ciudaddestino,
                            Tolerancia_Destino = 0,
                            status = 1,
                            IdServiceTypes = travel.TravelServiceId,
                            SectionId = section.Id
                        };

                        await _dbContext.Oferta.AddAsync(newoferta);
                        await _dbContext.SaveChangesAsync();
                    }
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost("{SectionId}")]
        public async Task<IActionResult> CloneSection(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections.FindAsync(SectionId);
                if (section is null)
                {
                    return NotFound();
                }

                Travel travel = await _dbContext.Travels.FindAsync(section.TravelId);
                if (travel is null)
                {
                    return NotFound();
                }

                Section lastsection = _dbContext.Sections.Where(x => x.TravelId == section.TravelId).ToList().LastOrDefault();
                int autoincrement = Int32.Parse(lastsection.Folio.Split("-")[1]) + 1;

                section.Id = 0;
                section.Folio = string.Concat(DateTime.Now.ToString("yyMM"), travel.Folio.Substring(travel.Folio.Length - 4), "-", autoincrement.ToString("D2"));
                section.TimeCreated = DateTime.Now;
                section.Espejo = null;
                section.Usuario = null;
                section.Contraseña = null;
                section.Empresa = null;

                await _dbContext.Sections.AddAsync(section);
                await _dbContext.SaveChangesAsync();

                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{SectionId}")]
        public async Task<IActionResult> CartaPorte(int SectionId)
        {
            try
            {
                Section section = await _dbContext.Sections
                    .Include(x => x.Ruta)
                    .Include(x => x.Services)
                    .ThenInclude(x => x.ServiceType)
                    .Include(x => x.Services)
                    .ThenInclude(x => x.Transportista)
                    .Include(x => x.Services)
                    .ThenInclude(x => x.Tr_Has_Operadores)
                    .Include(x => x.Clients)
                    .Include(x => x.Cl_Has_Origen)
                    .Include(x => x.Cl_Has_Destinos)
                    .Include(x => x.SectionType)
                    //.Include(x => x.Empresa)
                    .SingleOrDefaultAsync(x => x.Id == SectionId);

                if (section is null)
                {
                    return NotFound();
                }
                return Ok(section);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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

                Section section = await _dbContext.Sections.Include(x => x.Ruta).SingleOrDefaultAsync(x => x.Id == model.SectionId);
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
                        unit = await _dbContext.Units.FindAsync(unitmodel.Id);
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

        [HttpGet("{CarrierId}")]
        public async Task<IActionResult> GetDrivers(int CarrierId)
        {
            try
            {
                ICollection<Tr_Has_Operadores> tr_Has_Operadores = await _dbContext.Tr_Has_Operadores.Where(x => x.Id_Transportista == CarrierId && x.estatus == 1).OrderBy(x => x.nombre).ToArrayAsync();
                //ICollection<Tr_Has_Operadores> tr_Has_Operadores = await _dbContext.Tr_Has_Operadores.Where(x => x.Id_Transportista == CarrierId && x.estatus == 1 && x.Imss != null && x.NoLicencia != null && x.NoIne != null && x.FotoLicencia != null && x.FotoIne != null && x.FotoSeguro != null).OrderBy(x => x.nombre).ToArrayAsync();
                return Ok(tr_Has_Operadores);
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
                    OD = string.Concat("Origen: ", _dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadoorigen).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudadorigen).nombre, " || Destino: ", _dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.id_estadodestino).nombre, ", ", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.id_ciudaddestino).nombre)
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

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetOffer(int Id)
        {
            try
            {
                Oferta oferta = await _dbContext.Oferta.FindAsync(Id);
                if (oferta is null)
                {
                    return NotFound();
                }
                return Ok(oferta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSubstatuses()
        {
            try
            {
                ICollection<Substatus> substatuses = await _dbContext.Substatuses.Include(x => x.Status).Where(x => x.Active).OrderBy(x => x.Status.Name).ToListAsync();
                return Ok(substatuses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
        #region DataTableTravels
        [HttpPost]
        public async Task<IActionResult> DataTableTravels(DTParams dtParams)
        {
            try
            {
                IEnumerable<TravelDT> sections = await _dbContext.Sections.Where(x => x.Active).Select(x => new TravelDT
                {
                    Id = x.Id,
                    MainTravelId = x.TravelId,
                    Folio = x.Folio,
                    Cliente = x.Clients.NombreCorto ?? "-",
                    Origen = !x.IsEmpty ? string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Origen.Id_Ciudad).nombre) : string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadoorigen).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Ruta.id_ciudadorigen).nombre),
                    Destino = !x.IsEmpty ? string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Cl_Has_Destinos.Id_Ciudad).nombre) : string.Concat(_dbContext.Cat_Estado.SingleOrDefault(y => y.id == x.Ruta.id_estadodestino).nombre, "-", _dbContext.Cat_Ciudad.SingleOrDefault(y => y.id == x.Ruta.id_ciudaddestino).nombre),
                    FechaSalida = x.FechaSalida.ToString("dd/MM/yyyy. hh:mm tt"),
                    FechaLlegada = x.FechaLlegada.ToString("dd/MM/yyyy. hh:mm tt"),
                    Estatus = string.Concat(x.Substatus.Status.Name, "-", x.Substatus.Name),
                    SubstatusId = x.SubstatusId
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

                if (dtParams.Filter.Any())
                {
                    sections = sections.Where(x => dtParams.Filter.Contains(x.SubstatusId));
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

                sections = sections.Skip(dtParams.start).Take(dtParams.length);

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
