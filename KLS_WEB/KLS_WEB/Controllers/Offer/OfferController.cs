﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Models.Oferta;
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
            public int status { get; set; }
            public int idtransportista { get; set; }
            public string nombreTran { get; set; }
            public string nivelOrigen { get; set; }
            public string nivelDestino { get; set; }
            public int idregionOrigen { get; set; }
            public int idregionDestino { get; set; }
            public int idoferta { get; set; }
        }

        [Route("DownloadLayout")]
        public FileResult DownloadLayout()
        {
            return File("Resources/LayoutOferta/CargaExcel.xlsx", "application/octet-stream", "CargaExcel.csv");
        }

        [HttpPost]
        [Route("setSeparar")]
        public async Task<JsonResult> setSeparar(Separar dataModel)
        {
            Separar dataReport;
            dataReport = await this.AppContext.Execute<Separar>(MethodType.POST, _UrlApi+"/Separar", dataModel);
            return Json(dataReport);
        }
        
        [HttpGet]
        [Route("getSeparar")]
        public async Task<JsonResult> getSeparar(Separar dataModel)
        {
            Separar dataReport;
            dataReport = await this.AppContext.Execute<Separar>(MethodType.GET, _UrlApi+"/getSeparar", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putSeparar")]
        public async Task<JsonResult> putSeparar(Separar dataModel)
        {
            Separar dataReport;
            dataReport = await this.AppContext.Execute<Separar>(MethodType.PUT, _UrlApi+ "/putSeparar", dataModel);
            return Json(dataReport);
        }
    }
}
