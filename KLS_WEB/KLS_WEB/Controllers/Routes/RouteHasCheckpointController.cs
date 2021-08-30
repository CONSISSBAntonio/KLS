using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Routes
{
    [Route("RouteHasCheckpoint")]
    [Authorize]
    public class RouteHasCheckpointController : Controller
    {
        private string _UrlView = "~/Views/Route/";
        private string _UrlApi = "RouteHasCheckpoint";
        private readonly IAppContextService AppContext;
        public RouteHasCheckpointController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getRouteHasCheckpoint")]
        public async Task<JsonResult> Get(Ruta_Has_Checkpoint dataModel)
        {
            List<Ruta_Has_Checkpoint> dataReport;
            dataReport = await this.AppContext.Execute<List<Ruta_Has_Checkpoint>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpGet]
        [Route("getRouteCheckpoint/{rutaid}")]
        public async Task<JsonResult> getRouteCheckpoint(int rutaid, Ruta_Has_Checkpoint dataModel)
        {
            List<Ruta_Has_Checkpoint> dataReport = await this.AppContext.Execute<List<Ruta_Has_Checkpoint>>(MethodType.GET, string.Concat(_UrlApi, "/getRouteCheckpoint/", rutaid), dataModel);

            return Json(dataReport);
        }

        [HttpPost]
        [Route("setRouteHasCheckpoint")]
        public async Task<JsonResult> Post(Ruta_Has_Checkpoint dataModel)
        {
            Ruta_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Ruta_Has_Checkpoint>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putRouteHasCheckpoint")]
        public async Task<JsonResult> Put(Ruta_Has_Checkpoint dataModel)
        {
            Ruta_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Ruta_Has_Checkpoint>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("deleteRouteHasCheckpoint")]
        public async Task<JsonResult> Delete(Ruta_Has_Checkpoint dataModel)
        {
            Ruta_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Ruta_Has_Checkpoint>(MethodType.DELETE, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
