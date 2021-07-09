using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Destinations")]
    public class DestinationsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Destinations/";
        private string _UrlApi = "Clients/Destinations/";

        private readonly IAppContextService AppContext;

        public DestinationsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getDestino")]
        public async Task<JsonResult> Get(Cl_Has_Destinos dataModel)
        {
            List<Cl_Has_Destinos> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Destinos>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setDestino")]
        public async Task<JsonResult> Post(Cl_Has_Destinos dataModel)
        {
            Cl_Has_Destinos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Destinos>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putDestino")]
        public async Task<JsonResult> Put(Cl_Has_Destinos dataModel)
        {
            Cl_Has_Destinos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Destinos>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
