using FileHelpers;
using KLS_WEB.Models;
using KLS_WEB.Models.Demand;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Demand
{
    public class DemandController : Controller
    {
        private string _UrlView = "~/Views/Demand/";
        private string _UrlApi = "Demands";
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly IAppContextService AppContext;

        public DemandController(IAppContextService _AppContext, IWebHostEnvironment webHostEnvironment)
        {
            AppContext = _AppContext;
            _hostingEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> AddEditDemand(DemandDTO model)
        {
            model.Id = model.Id == -1 ? 0 : model.Id;
            string action = model.Id == 0 ? "SetDemand" : "PutDemand";
            var verb = model.Id == 0 ? MethodType.POST : MethodType.PUT;
            DemandDTO demand = await AppContext.Execute<DemandDTO>(verb, Path.Combine(_UrlApi, action), model);

            return Json(demand);
        }

        [HttpPost]
        public async Task<JsonResult> DT(DataTablesParameters dtParams)
        {
            DTModel data = await AppContext.Execute<DTModel>(MethodType.POST, Path.Combine(_UrlApi, "DT"), dtParams);

            return Json(data);
        }

        [HttpGet]
        public async Task<JsonResult> GetDemand(string Id)
        {
            DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", Id), null);
            return Json(demand);
        }

        //[Route("[controller]/[action]/{DemandId}")]
        //public async Task<IActionResult> SetTravel(string DemandId)
        //{
        //    DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", DemandId), null);

        //    Travel lasttravel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine("Travels", "GetTravel", "0"), null);

        //    Travel travel = new Travel
        //    {
        //        Id = lasttravel == null ? 1 : lasttravel.Id,
        //        ClienteId = demand.ClientId,
        //        TipoUnidad = demand.UnitId,
        //        Origen = demand.OriginId,
        //        Destino = demand.DestinationId,
        //        Ruta = demand.RouteId,
        //        FechaSalida = demand.FechaDisponibilidad,
        //        IsDemand = true
        //    };

        //    return View("~/Views/Travels/New.cshtml", travel);
        //}

        //public async Task<IActionResult> SetFullTravel(string DemandId, int CarrierId)
        //{
        //    DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", DemandId), null);

        //    Travel lasttravel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine("Travels", "GetTravel", "0"), null);

        //    Travel travel = new Travel
        //    {
        //        Id = lasttravel == null ? 1 : lasttravel.Id,
        //        ClienteId = demand.ClientId,
        //        TipoUnidad = demand.UnitId,
        //        Origen = demand.OriginId,
        //        Destino = demand.DestinationId,
        //        Ruta = demand.RouteId,
        //        FechaSalida = demand.FechaDisponibilidad,
        //        Transportista = CarrierId,
        //        IsDemand = true
        //    };

        //    return View("~/Views/Travels/New.cshtml", travel);
        //}

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

        [HttpPost]
        public async Task<JsonResult> GetCarrier(string OriginId, string UnitId, string RouteId)
        {
            List<CarrierDT> carriers = await AppContext.Execute<List<CarrierDT>>(MethodType.GET, string.Concat(_UrlApi, "/GetCarrier?OriginId=", OriginId, "&UnidadId=", UnitId, "&RouteId=", RouteId), null);
            return Json(carriers);
        }

        [DelimitedRecord(",")]
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
        public async Task<FileResult> CSV([FromBody] List<DemandExcel> demands)
        {
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "DemandsExcel");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            List<DemandExcel> report = new List<DemandExcel>();
            Report response = new Report();
            string reportpath = string.Empty;

            if (demands.Any())
            {
                response = await AppContext.Execute<Report>(MethodType.POST, Path.Combine(_UrlApi, "ImportDemands"), demands);

                #region Reporte
                if (response.Added.Any())
                {
                    report.Add(new DemandExcel { Cliente = "DEMANDAS AGREGADAS CON EXITO" });
                    foreach (var demand in response.Added)
                    {
                        report.Add(demand);
                    }
                }

                if (response.PastDate.Any())
                {
                    report.Add(new DemandExcel { Cliente = "FECHA INVALIDA" });
                    foreach (var demand in response.PastDate)
                    {
                        report.Add(demand);
                    }
                }

                if (response.NoClient.Any())
                {
                    report.Add(new DemandExcel { Cliente = "NO SE ENCONTRO EL CLIENTE" });
                    foreach (var demand in response.NoClient)
                    {
                        report.Add(demand);
                    }
                }

                if (response.NoUnit.Any())
                {
                    report.Add(new DemandExcel { Cliente = "NO SE ENCONTRO EL TIPO DE UNIDAD" });
                    foreach (var demand in response.NoUnit)
                    {
                        report.Add(demand);
                    }
                }

                if (response.NoOrigin.Any())
                {
                    report.Add(new DemandExcel { Cliente = "NO SE ENCONTRO EL ORIGEN" });
                    foreach (var demand in response.NoOrigin)
                    {
                        report.Add(demand);
                    }
                }

                if (response.NoDestination.Any())
                {
                    report.Add(new DemandExcel { Cliente = "NO SE ENCONTRO EL DESTINO" });
                    foreach (var demand in response.NoDestination)
                    {
                        report.Add(demand);
                    }
                }

                if (response.NoRoute.Any())
                {
                    report.Add(new DemandExcel { Cliente = "NO SE ENCONTRO LA RUTA" });
                    foreach (var demand in response.NoRoute)
                    {
                        report.Add(demand);
                    }
                }
                #endregion

                var engine = new FileHelperEngine<DemandExcel>();
                reportpath = Path.Combine(path, string.Concat("Reporte.csv"));
                engine.WriteFile(reportpath, report);
            }

            string reportname = string.Concat("Reporte - ", DateTime.Now.ToString("dd MMMM hh.mm"), ".csv");

            return File("/DemandsExcel/Reporte.csv", "application/octet-stream", reportname);
        }

        [Route("[action]")]
        public FileResult DownloadLayout()
        {
            return File("/DemandsExcel/Layout.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "PlantillaCargaDemandas.xlsx");
        }

        public class Total
        {
            public int TotalDemands { get; set; }
        }

        [HttpGet]
        public async Task<JsonResult> CountDemands()
        {
            var total = await AppContext.Execute<Total>(MethodType.GET, Path.Combine(_UrlApi, "CountDemands"), null);
            return Json(total);
        }
    }
}
