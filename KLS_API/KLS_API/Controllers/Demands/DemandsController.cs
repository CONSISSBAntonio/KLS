using KLS_API.Context;
using KLS_API.Models.Demands;
using KLS_API.Models.DT;
using Microsoft.AspNetCore.Mvc;
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
                demand.Folio = string.Concat("D", DateTime.Now.ToString("ddMM"), id.ToString("D4"));
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
        class DTModel
        {
            public int Id { get; set; }
            public string Folio { get; set; }
            public string Cliente { get; set; }
            public string TipoUnidad { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public string FechaDisponibilidad { get; set; }
            public string Arribo { get; set; }
        }

        [HttpPost]
        public IActionResult DT([FromBody] DTParams dtParams)
        {
            try
            {
                IEnumerable<DTModel> demands = (from demand in _dbContext.Demands
                                                where demand.Status == "nueva"

                                                join client in _dbContext.Clientes on demand.ClientId equals client.id
                                                into demandclient
                                                from clientdata in demandclient.DefaultIfEmpty()

                                                join unit in _dbContext.Cat_Tipos_Unidades on demand.UnitId equals unit.id
                                                into demandunit
                                                from unitdata in demandunit.DefaultIfEmpty()

                                                join ciudadorigen in _dbContext.Cat_Ciudad on demand.CiudadIdOrigen equals ciudadorigen.id
                                                into ciudadorigen
                                                from ciudadorigendata in ciudadorigen.DefaultIfEmpty()

                                                join ciudaddestino in _dbContext.Cat_Ciudad on demand.CiudadIdDestino equals ciudaddestino.id
                                                into ciudaddestinodemand
                                                from ciudaddestinodata in ciudaddestinodemand.DefaultIfEmpty()

                                                    //join origin in _dbContext.Cl_Has_Origen on demand.ClientId equals origin.Id_Cliente
                                                    //into demandorigin
                                                    //from origindata in demandorigin.DefaultIfEmpty()

                                                    //join destination in _dbContext.Cl_Has_Destinos on demand.des equals destination.Id_Cliente
                                                    //into demanddestination
                                                    //from destinationdata in demanddestination.DefaultIfEmpty()

                                                select new DTModel
                                                {
                                                    Id = demand.Id,
                                                    Folio = demand.Folio,
                                                    Cliente = clientdata.NombreCorto,
                                                    TipoUnidad = unitdata.nombre,
                                                    Origen = ciudadorigendata.nombre,
                                                    Destino = ciudaddestinodata.nombre,
                                                    FechaDisponibilidad = demand.FechaDisponibilidad.ToString("dd/MM/yyyy. HH:mm tt"),
                                                    Arribo = demand.Arribo == null ? "" : demand.Arribo
                                                }).ToList();
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
    }
}
