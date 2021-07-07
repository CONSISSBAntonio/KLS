using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersRoutes
{
    [Route("Carriers/Routes")]
    [Authorize]
    public class RoutesController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Routes/";
        private string _UrlApi = "Carriers/Routes";

        private readonly IAppContextService AppContext;

        public RoutesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getRoutes")]
        public async Task<JsonResult> Get(Route dataModel)
        {
            List<Route> dataReport;
            dataReport = await this.AppContext.Execute<List<Route>>(MethodType.GET,"Route", dataModel);
            return Json(dataReport);
        }
        
        [Route("getRuta")]
        public async Task<JsonResult> getRuta(Tr_Has_Rutas dataModel)
        {
            List<Tr_Has_Rutas> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Rutas>>(MethodType.GET,_UrlApi, dataModel);
            return Json(dataReport);
        }


        [Route("setRoutes")]
        public async Task<JsonResult> Post(Tr_Has_Rutas dataModel)
        {
            Tr_Has_Rutas dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Rutas>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putRoutes")]
        public async Task<JsonResult> Put(Tr_Has_Rutas dataModel)
        {
            Tr_Has_Rutas dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Rutas>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
