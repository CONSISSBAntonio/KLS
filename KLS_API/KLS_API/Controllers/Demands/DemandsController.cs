using KLS_API.Context;
using KLS_API.Models;
using KLS_API.Models.Clients;
using KLS_API.Models.Demands;
using KLS_API.Models.DT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Demands
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DemandsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public DemandsController(AppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        [HttpPost]
        public IActionResult SetDemand([FromBody] Demand demand)
        {
            try
            {
                bool clrutaexists = _dbContext.Cl_Has_Routes.Any(x => x.Id_Ruta == demand.RouteId && x.Id_Cliente == demand.ClientId);
                if (!clrutaexists)
                {
                    var clhasroutes = new Cl_Has_Routes
                    {
                        Id_Ruta = demand.RouteId,
                        Id_Cliente = demand.ClientId,
                        Monitoreable = false,
                        Estatus = 1
                    };
                    _dbContext.Cl_Has_Routes.Add(clhasroutes);
                }
                var lastDemand = _dbContext.Demands.OrderByDescending(x => x.Id).FirstOrDefault();
                int id = lastDemand is null ? 1 : lastDemand.Id + 1;
                demand.Folio = string.Concat("D", DateTime.Now.ToString("yyMM"), id.ToString("D4"));
                demand.Status = "nueva";
                demand.TimeCreated = DateTime.Now;
                _dbContext.Demands.Add(demand);
                _dbContext.SaveChanges();

                return Ok(demand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult PutDemand([FromBody] Demand demand)
        {
            try
            {
                Demand entry = _dbContext.Demands.Find(demand.Id);
                if (entry != null)
                {
                    entry.ClientId = demand.ClientId;
                    entry.UnitId = demand.UnitId;
                    entry.OriginId = demand.OriginId;
                    entry.DestinationId = demand.DestinationId;
                    entry.RouteId = demand.RouteId;
                    entry.FechaDisponibilidad = demand.FechaDisponibilidad;
                    entry.Arribo = demand.Arribo;
                    entry.TimeUpdated = DateTime.Now;
                    _dbContext.SaveChanges();
                }

                return Ok(demand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        class DTModel
        {
            public int Id { get; set; }
            public int ClientId { get; set; }
            public int OriginId { get; set; }
            public int UnitId { get; set; }
            public int DestinationId { get; set; }
            public int RouteId { get; set; }
            public string Folio { get; set; }
            public string Cliente { get; set; }
            public string TipoUnidad { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public string FechaDisponibilidad { get; set; }
            public string Arribo { get; set; }
            public int OfertasCount { get; set; }
            public string Status { get; set; }
        }

        [HttpPost]
        public IActionResult DT([FromBody] DTParams dtParams)
        {
            try
            {
                IEnumerable<DTModel> demands = !dtParams.CustomSearch ? (
                    _dbContext.Demands.Where(x => x.Status == "nueva" && x.FechaDisponibilidad >= DateTime.Now).Select(x => new DTModel
                    {
                        Id = x.Id,
                        ClientId = x.ClientId,
                        OriginId = x.OriginId,
                        DestinationId = x.DestinationId,
                        RouteId = x.RouteId,
                        Folio = x.Folio,
                        Cliente = x.Client.NombreCorto,
                        UnitId = x.Unit.id,
                        TipoUnidad = x.Unit.nombre,
                        Origen = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Origin.Id_Estado).nombre.Trim(), "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Origin.Id_Ciudad).nombre.Trim()),
                        Destino = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Destination.Id_Estado).nombre.Trim(), "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Destination.Id_Ciudad).nombre.Trim()),
                        FechaDisponibilidad = x.FechaDisponibilidad.ToString("dd/MM/yyyy. hh:mm tt"),
                        Arribo = x.Arribo ?? "-",
                        OfertasCount = 0,
                        //OfertasCount = _dbContext.Oferta.Where(y => (y.ciudad_Destino == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == x.OriginId).Id_Ciudad && y.Tipo_De_Unidad == x.UnitId)).Count(),
                        Status = x.Status
                    }).ToList()
                ) : (
                _dbContext.Demands.Where(x => (x.Status == "nueva" && x.FechaDisponibilidad >= DateTime.Now) && x.ClientId == dtParams.searchmodel.ClientId || x.UnitId == dtParams.searchmodel.UnitId ||
                x.FechaDisponibilidad == dtParams.searchmodel.FechaSalida || x.Origin.Id_Estado == dtParams.searchmodel.EstadoOrigenId ||
                x.Origin.Id_Ciudad == dtParams.searchmodel.CiudadOrigenId || x.Destination.Id_Estado == dtParams.searchmodel.EstadoDestinoId ||
                x.Destination.Id_Ciudad == dtParams.searchmodel.CiudadDestinoId || x.Client.Tamanio == dtParams.searchmodel.TamañoEmpresa).Select(x => new DTModel
                {
                    Id = x.Id,
                    ClientId = x.ClientId,
                    OriginId = x.OriginId,
                    DestinationId = x.DestinationId,
                    RouteId = x.RouteId,
                    Folio = x.Folio,
                    Cliente = x.Client.NombreCorto,
                    TipoUnidad = x.Unit.nombre,
                    Origen = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Origin.Id_Estado).nombre.Trim(), "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Origin.Id_Ciudad).nombre.Trim()),
                    Destino = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Destination.Id_Estado).nombre.Trim(), "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Destination.Id_Ciudad).nombre.Trim()),
                    FechaDisponibilidad = x.FechaDisponibilidad.ToString("dd/MM/yyyy. hh:mm tt"),
                    Arribo = x.Arribo ?? "-",
                    OfertasCount = 0,
                    //OfertasCount = _dbContext.Oferta.Where(y => y.ciudad_Destino == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == x.OriginId).Id_Ciudad && y.Tipo_De_Unidad == x.UnitId).Count(),
                    Status = x.Status
                }).ToList()
                );

                if (dtParams.searchmodel != null && dtParams.searchmodel.FiltroCliente != null)
                {
                    demands = demands.Where(x => dtParams.searchmodel.FiltroCliente.Contains(x.ClientId));
                }

                int total = demands.Count();

                if (dtParams.search != null)
                {
                    string keyword = dtParams.search.value[0] is null ? "" : dtParams.search.value[0].ToLower();

                    demands = demands.Where(x => x.Folio.ToLower().Contains(keyword) ||
                    x.Cliente.ToLower().Contains(keyword) || x.TipoUnidad.ToLower().Contains(keyword) ||
                    x.Origen.ToLower().Contains(keyword) || x.Destino.ToLower().Contains(keyword) ||
                    x.FechaDisponibilidad.ToLower().Contains(keyword) || x.Arribo.ToLower().Contains(keyword));
                }

                int totalFiltered = demands.Count();

                int columnId = dtParams.order != null ? dtParams.order[0].column[0] : 0;

                string func(DTModel x) => columnId == 0 ? x.Folio :
                columnId == 1 ? x.Cliente : columnId == 2 ? x.TipoUnidad :
                columnId == 3 ? x.Origen : columnId == 4 ? x.Destino :
                columnId == 5 ? x.FechaDisponibilidad : x.Arribo;

                if (dtParams.order != null)
                {
                    demands = dtParams.order[0].dir[0] == "asc" ? demands.OrderBy(func) : demands.OrderByDescending(func);
                }

                demands = demands.Skip(dtParams.start).Take(dtParams.length);

                return Ok(new
                {
                    aaData = demands,
                    dtParams.draw,
                    iTotalRecords = total,
                    iTotalDisplayRecords = totalFiltered
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetDemand(int Id)
        {
            try
            {
                return Ok(_dbContext.Demands.Find(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public class CarrierDT
        {
            public int Id { get; set; }
            public int CarrierId { get; set; }
            public string Carrier { get; set; }
            public int UnitId { get; set; }
            public string Unit { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string FechaDisponibilidad { get; set; }
            public DateTime Expira { get; set; }
            public string Costo { get; set; }
        }

        [HttpGet]
        public IActionResult GetCarrier([FromQuery] int OriginId, int UnidadId, int RouteId)
        {
            try
            {
                string specifier = "C";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("es-MX");

                int[] regions = _dbContext.Region_Has_Estado.Where(x => x.id_estado == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == OriginId).Id_Estado).Select(x => x.Cat_RegionId).ToArray();

                List<CarrierDT> carriers = _dbContext.Oferta.Where(x => (x.ciudad_Destino == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == OriginId && x.Fecha_Disponibilidad > DateTime.Now).Id_Ciudad
                && x.Tipo_De_Unidad == UnidadId) || (x.Nivel_Destino.ToLower() == "region" && regions.Contains(x.Region_Destino)) || (x.Nivel_Destino.ToLower() == "estado" && x.estado_Destino == _dbContext.Cl_Has_Origen.FirstOrDefault(y => y.Id == OriginId && x.Fecha_Disponibilidad > DateTime.Now).Id_Estado)).Select(x => new CarrierDT
                {
                    Id = x.Id,
                    CarrierId = x.Transportista,
                    Carrier = _dbContext.Transportista.FirstOrDefault(y => y.id == x.Transportista).NombreComercial,
                    UnitId = x.Tipo_De_Unidad,
                    Unit = _dbContext.Cat_Tipos_Unidades.FirstOrDefault(y => y.id == x.Tipo_De_Unidad).nombre,
                    Origin = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Estado_Origen).nombre.Trim(), "-",
                    _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.ciudad_Origen).nombre.Trim(), " (",
                    x.Tolerancia_Origen, " km)"),
                    Destination = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.estado_Destino).nombre.Trim(), "-",
                    _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.ciudad_Destino).nombre.Trim(), " (",
                    x.Tolerancia_Destino, " km)"),
                    FechaDisponibilidad = x.Fecha_Disponibilidad.ToString("g"),
                    Expira = x.Fecha_Disponibilidad,
                    Costo = _dbContext.Tr_Has_Rutas.Any(y => y.Id_Transportista == x.Transportista && y.Id_Ruta == RouteId) ? _dbContext.ruta_has_inventario.FirstOrDefault(y => y.Tr_Has_RutaId == _dbContext.Tr_Has_Ruta.FirstOrDefault(z => z.Id_Transportista == x.Transportista && z.Id_Ruta == RouteId).Id).CostoOne.ToString(specifier, culture) : "TRANSPORTISTA SIN COSTOS DEFINIDOS"
                }).ToList();

                return Ok(carriers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }
        public class DemandExcel
        {
            public string Cliente { get; set; }
            public string TipoUnidad { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public DateTime FechaSalida { get; set; }
            public string Arribo { get; set; }
        }

        public class Report
        {
            public List<DemandExcel> Added { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> PastDate { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> NoClient { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> NoUnit { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> NoOrigin { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> NoDestination { get; set; } = new List<DemandExcel>();
            public List<DemandExcel> NoRoute { get; set; } = new List<DemandExcel>();
        }

        [HttpPost]
        public IActionResult ImportDemands([FromBody] List<DemandExcel> demands)
        {
            try
            {
                Report report = new Report();

                foreach (DemandExcel demand in demands)
                {
                    if (demand.FechaSalida < DateTime.Now)
                    {
                        report.PastDate.Add(demand);
                        continue;
                    }
                    Clientes client = _dbContext.Clientes.FirstOrDefault(x => x.NombreComercial.Replace(" ", "").ToLower() == demand.Cliente.Replace(" ", "").ToLower() || x.NombreCorto.Replace(" ", "").ToLower() == demand.Cliente.Replace(" ", "").ToLower());

                    if (client != null)
                    {

                        Cat_Tipos_Unidades unit = _dbContext.Cat_Tipos_Unidades.FirstOrDefault(x => x.nombre.Replace(" ", "").ToLower() == demand.TipoUnidad.Replace(" ", "").ToLower());
                        Cl_Has_Origen origin = _dbContext.Cl_Has_Origen.FirstOrDefault(x => x.Id_Cliente == client.id && x.Nombre.Replace(" ", "").ToLower() == demand.Origen.Replace(" ", "").ToLower());
                        Cl_Has_Destinos destination = _dbContext.Cl_Has_Destinos.FirstOrDefault(x => x.Id_Cliente == client.id && x.Nombre.Replace(" ", "").ToLower() == demand.Destino.Replace(" ", "").ToLower());

                        if (unit == null || origin == null || destination == null)
                        {
                            if (unit == null)
                                report.NoUnit.Add(demand);
                            if (origin == null)
                                report.NoOrigin.Add(demand);
                            if (destination == null)
                                report.NoDestination.Add(demand);
                            continue;
                        }

                        Ruta route = _dbContext.Ruta.FirstOrDefault(x => x.id_ciudadorigen == _dbContext.Cl_Has_Origen.Find(origin.Id).Id_Ciudad && x.id_ciudaddestino == _dbContext.Cl_Has_Destinos.Find(destination.Id).Id_Ciudad);

                        if (route == null)
                        {
                            report.NoRoute.Add(demand);
                            continue;
                        }

                        Demand lastDemand = _dbContext.Demands.OrderByDescending(x => x.Id).FirstOrDefault();
                        int lastdemandid = lastDemand is null ? 1 : lastDemand.Id + 1;
                        Demand demandDTO = new Demand
                        {
                            ClientId = client.id,
                            UnitId = unit.id,
                            OriginId = origin.Id,
                            DestinationId = destination.Id,
                            RouteId = route.id,
                            Folio = string.Concat("D", DateTime.Now.ToString("yyMM"), lastdemandid.ToString("D4")),
                            FechaDisponibilidad = demand.FechaSalida,
                            Arribo = demand.Arribo,
                            Status = "nueva",
                            TimeCreated = DateTime.Now
                        };

                        _dbContext.Demands.Add(demandDTO);
                        report.Added.Add(demand);
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        report.NoClient.Add(demand);
                    }
                }
                return Ok(report);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }
        public class Total
        {
            public int TotalDemands { get; set; }
        }

        [HttpGet]
        public IActionResult CountDemands()
        {
            try
            {
                Total total = new Total
                {
                    TotalDemands = _dbContext.Demands.Where(x => x.Status == "nueva" && x.FechaDisponibilidad >= DateTime.Now).Count()
                };

                return Ok(total);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }
    }
}
