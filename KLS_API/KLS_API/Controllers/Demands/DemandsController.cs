using KLS_API.Context;
using KLS_API.Models.Demands;
using KLS_API.Models.DT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            public int DestinationId { get; set; }
            public string Folio { get; set; }
            public string Cliente { get; set; }
            public string TipoUnidad { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public string FechaDisponibilidad { get; set; }
            public string Arribo { get; set; }
            public string Status { get; set; }
        }

        [HttpPost]
        public IActionResult DT([FromBody] DTParams dtParams)
        {
            try
            {
                IEnumerable<DTModel> demands = !dtParams.CustomSearch ? (
                    _dbContext.Demands.Where(x => x.Status == "nueva").Select(x => new DTModel
                    {
                        Id = x.Id,
                        ClientId = x.ClientId,
                        OriginId = x.OriginId,
                        DestinationId = x.DestinationId,
                        Folio = x.Folio,
                        Cliente = x.Client.NombreCorto,
                        TipoUnidad = x.Unit.nombre,
                        Origen = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Origin.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Origin.Id_Ciudad).nombre),
                        Destino = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Destination.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Destination.Id_Ciudad).nombre),
                        FechaDisponibilidad = x.FechaDisponibilidad.ToString("dd/MM/yyyy. HH:mm tt"),
                        Arribo = x.Arribo ?? "-",
                        Status = x.Status
                    }).ToList()
                ) : (
                _dbContext.Demands.Where(x => (x.Status == "nueva") && x.ClientId == dtParams.searchmodel.ClientId || x.UnitId == dtParams.searchmodel.UnitId ||
                x.FechaDisponibilidad == dtParams.searchmodel.FechaSalida || x.Origin.Id_Estado == dtParams.searchmodel.EstadoOrigenId ||
                x.Origin.Id_Ciudad == dtParams.searchmodel.CiudadOrigenId || x.Destination.Id_Estado == dtParams.searchmodel.EstadoDestinoId ||
                x.Destination.Id_Ciudad == dtParams.searchmodel.CiudadDestinoId || x.Client.Tamanio == dtParams.searchmodel.TamañoEmpresa).Select(x => new DTModel
                {
                    Id = x.Id,
                    ClientId = x.ClientId,
                    OriginId = x.OriginId,
                    DestinationId = x.DestinationId,
                    Folio = x.Folio,
                    Cliente = x.Client.NombreCorto,
                    TipoUnidad = x.Unit.nombre,
                    Origen = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Origin.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Origin.Id_Ciudad).nombre),
                    Destino = string.Concat(_dbContext.Cat_Estado.FirstOrDefault(y => y.id == x.Destination.Id_Estado).nombre, "-", _dbContext.Cat_Ciudad.FirstOrDefault(y => y.id == x.Destination.Id_Ciudad).nombre),
                    FechaDisponibilidad = x.FechaDisponibilidad.ToString("dd/MM/yyyy. HH:mm tt"),
                    Arribo = x.Arribo ?? "-",
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

        //public class CarrierDT
        //{
        //    public int Id { get; set; }
        //    public int CarrierId { get; set; }
        //    public string Carrier { get; set; }
        //    public int UnitId { get; set; }
        //    public string Unit { get; set; }
        //    public string Origin { get; set; }
        //    public string Destination { get; set; }
        //    public string FechaDisponibilidad { get; set; }
        //    public DateTime Expira { get; set; }
        //    public decimal Costo { get; set; }
        //}

        //[HttpGet]
        //public IActionResult GetCarrier([FromQuery] int OriginId, int DestinationId)
        //{
        //    try
        //    {
        //        List<CarrierDT> carriers = _dbContext.Transportista.Where(x => x.id)
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //        throw;
        //    }
        //}
    }
}
