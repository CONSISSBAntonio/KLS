﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Models.Oferta;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Offer
{
    [Route("Offer/")]
    [Authorize]
    public class OfferController : Controller
    {
        private string _UrlView = "~/Views/Offer/";
        private string _UrlApi = "Offer";
        private readonly IAppContextService AppContext;
        public OfferController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        //Guardar ofertas masivas
        [HttpPost]
        [Route("setRouteMult")]
        public async Task<JsonResult> setRouteMult(Carga dataModel)
        {
            Carga dataReport;
            dataReport = await this.AppContext.Execute<Carga>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("busqueda")]
        public async Task<JsonResult> Get(ofertas dataModel)
        {
            List<ofertas> dataReport;
            dataReport = await this.AppContext.Execute<List<ofertas>>(MethodType.GET, _UrlApi+ "/busquedas", dataModel);
            return Json(dataReport);
        }
        
        [Route("listTransportista")]
        public async Task<JsonResult> listTransportista()
        {
            List<listTran> dataReport;
            dataReport = await this.AppContext.Execute<List<listTran>>(MethodType.GET, _UrlApi+ "/listTransportistas", null);
            return Json(dataReport);
        }

        public class listTran
        {
            public string nombre { get; set; }
            public int idesorigen { get; set; }
            public int idesdestino { get; set; }
            public int idcorigen { get; set; }
            public int idcdestino { get; set; }
            public string estadoorigen { get; set; }
            public string estadodestino { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public decimal costo { get; set; }
            public int estatus { get; set; }
        }

        public class ofertas
        {
            public int idestadoorigen { get; set; }
            public int idestadodestino { get; set; }
            public int idciudadorigen { get; set; }
            public int idciudaddestino { get; set; }
            public int idtipounidad { get; set; }
            public int seltransportista { get; set; }
            public string estadoorigen { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public string estadodestino { get; set; }
            public string tipounidad { get; set; }
            public DateTime fechadisponibilidad { get; set; }
            public int transportista { get; set; }
            public int estatus { get; set; }
            public int idtransportista { get; set; }
            public string nombreTran { get; set; }
        }

        public async Task<IActionResult> SetFullTravel(string OfferId)
        {
            Oferta demand = await AppContext.Execute<Oferta>(MethodType.GET, Path.Combine(_UrlApi, "GetOffer", OfferId), null);

            Travel lasttravel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine("Travels", "GetTravel", "0"), null);

            Travel travel = new Travel
            {
                Id = lasttravel == null ? 1 : lasttravel.Id,
                TipoUnidad = demand.Tipo_De_Unidad,
                FechaSalida = demand.Fecha_Disponibilidad,
                Transportista = demand.Transportista,
                IsDemand = true
            };

            return View("~/Views/Travels/New.cshtml", travel);
        }
    }
}
