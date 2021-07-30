﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models.Search;
using KLS_WEB.Models.Demand;
using KLS_WEB.Services;
using KLS_WEB.Models;
using System.IO;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Travels;

namespace KLS_WEB.Controllers.Demand
{
    public class DemandController : Controller
    {
        private string _UrlView = "~/Views/Demand/";
        private string _UrlApi = "Demands";

        private readonly IAppContextService AppContext;

        public DemandController(IAppContextService _AppContext)
        {
            AppContext = _AppContext;
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
        public async Task<JsonResult> DT(DataTablesParameters dtParams) {
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
                Id = lasttravel.Id,
                ClienteId = demand.ClientId,
                TipoUnidad = demand.UnitId,
                Origen = demand.OriginId,
                Destino = demand.DestinationId,
                Ruta = demand.RouteId,
                FechaSalida = demand.FechaDisponibilidad
            };

            return View("~/Views/Travels/New.cshtml", travel);
        }
    }
}
