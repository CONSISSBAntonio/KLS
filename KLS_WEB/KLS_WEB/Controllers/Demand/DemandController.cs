using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models.Demand;
using KLS_WEB.Services;
using KLS_WEB.Models;
using System.IO;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Travels;
using Microsoft.AspNetCore.Http;
using FileHelpers;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

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

        public IActionResult Index()
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

        [Route("[controller]/[action]/{DemandId}")]
        public async Task<IActionResult> SetTravel(string DemandId)
        {
            DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", DemandId), null);

            Travel lasttravel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine("Travels", "GetTravel", "0"), null);

            Travel travel = new Travel
            {
                Id = lasttravel == null ? 1 : lasttravel.Id,
                ClienteId = demand.ClientId,
                TipoUnidad = demand.UnitId,
                Origen = demand.OriginId,
                Destino = demand.DestinationId,
                Ruta = demand.RouteId,
                FechaSalida = demand.FechaDisponibilidad,
                IsDemand = true
            };

            return View("~/Views/Travels/New.cshtml", travel);
        }

        public async Task<IActionResult> SetFullTravel(string DemandId, int CarrierId)
        {
            DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", DemandId), null);

            Travel lasttravel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine("Travels", "GetTravel", "0"), null);

            Travel travel = new Travel
            {
                Id = lasttravel == null ? 1 : lasttravel.Id,
                ClienteId = demand.ClientId,
                TipoUnidad = demand.UnitId,
                Origen = demand.OriginId,
                Destino = demand.DestinationId,
                Ruta = demand.RouteId,
                FechaSalida = demand.FechaDisponibilidad,
                Transportista = CarrierId,
                IsDemand = true
            };

            return View("~/Views/Travels/New.cshtml", travel);
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

        [HttpPost]
        public async Task<JsonResult> GetCarrier(string OriginId, string UnitId)
        {
            List<CarrierDT> carriers = await AppContext.Execute<List<CarrierDT>>(MethodType.GET, string.Concat(_UrlApi, "/GetCarrier?OriginId=", OriginId, "&UnidadId=", UnitId), null);
            return Json(carriers);
        }

        [DelimitedRecord(","), IgnoreFirst(1)]
        public class DemandsCSV
        {
            public string Cliente { get; set; }
            public string TipoUnidad { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public DateTime FechaSalida { get; set; }
            public string Arribo { get; set; }
        }
        public class CSVReport
        {
            public List<DemandsCSV> Added { get; set; }
            public List<DemandsCSV> NoClient { get; set; }
            public List<DemandsCSV> NoUnit { get; set; }
            public List<DemandsCSV> NoOrigin { get; set; }
            public List<DemandsCSV> NoDestination { get; set; }
            public List<DemandsCSV> NoRoute { get; set; }
        }

        public class Carga
        {
            public List<DemandsCSV> demands { get; set; }
        }
        [HttpPost]
        public async Task<FileResult> CSV(List<DemandsCSV> demands)
        {
            //string path = Path.Combine(_hostingEnvironment.WebRootPath, "DemandsCSV");
            //List<DemandsCSV> report = new List<DemandsCSV>();
            //CSVReport response = new CSVReport
            //{
            //    Added = new List<DemandsCSV>(),
            //    NoClient = new List<DemandsCSV>(),
            //    NoUnit = new List<DemandsCSV>(),
            //    NoOrigin = new List<DemandsCSV>(),
            //    NoDestination = new List<DemandsCSV>(),
            //    NoRoute = new List<DemandsCSV>()
            //};
            //string reportpath = string.Empty;

            //if (csv != null)
            //{
            //    response = await AppContext.Execute<CSVReport>(MethodType.POST, Path.Combine(_UrlApi, "DemandCSV"), csv);

            //    #region Reporte
            //    if (response.Added.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "DEMANDAS AGREGADAS CON EXITO" });
            //        foreach (var demand in response.Added)
            //        {
            //            report.Add(demand);
            //        }
            //    }

            //    if (response.NoClient.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "NO SE ENCONTRO EL CLIENTE" });
            //        foreach (var demand in response.NoClient)
            //        {
            //            report.Add(demand);
            //        }
            //    }

            //    if (response.NoUnit.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "NO SE ENCONTRO EL TIPO DE UNIDAD" });
            //        foreach (var demand in response.NoUnit)
            //        {
            //            report.Add(demand);
            //        }
            //    }

            //    if (response.NoOrigin.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "NO SE ENCONTRO EL ORIGEN" });
            //        foreach (var demand in response.NoOrigin)
            //        {
            //            report.Add(demand);
            //        }
            //    }

            //    if (response.NoDestination.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "NO SE ENCONTRO EL DESTINO" });
            //        foreach (var demand in response.NoDestination)
            //        {
            //            report.Add(demand);
            //        }
            //    }

            //    if (response.NoRoute.Any())
            //    {
            //        report.Add(new DemandsCSV { Cliente = "NO SE ENCONTRO LA RUTA" });
            //        foreach (var demand in response.NoRoute)
            //        {
            //            report.Add(demand);
            //        }
            //    }
            //    #endregion

            //    var engine = new FileHelperEngine<DemandsCSV>();
            //    reportpath = Path.Combine(path, string.Concat("Reporte.csv"));
            //    engine.WriteFile(reportpath, report);
            //}

            return File(string.Concat("/DemandsCSV/", "Reporte.csv"), "application/octet-stream", string.Concat("Reporte.csv"));
        }

        [HttpGet]
        public FileResult DownloadLayout()
        {
            return File("/DemandsCSV/Layout.csv", "application/octet-stream", "PlantillaCargaMasivaDemandas.csv");
        }
    }
}
