using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Views.Catalogs.City
{
    [Route("Route")]
    public class RouteController : Controller
    {
        private string _UrlView = "~/Views/Route/";
        private string _UrlApi = "Route";
        private readonly IAppContextService AppContext;
        public RouteController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "Index.cshtml");
        }

        [Route("getRoute")]
        public async Task<JsonResult> Get(Route dataModel)
        {
            List<Route> dataReport;
            dataReport = await this.AppContext.Execute<List<Route>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("[action]")]
        public async Task<JsonResult> GetRoutes()
        {
            RouteDTO dataModel = new RouteDTO();
            List<RouteDTO> dataReport;
            dataReport = await this.AppContext.Execute<List<RouteDTO>>(MethodType.GET, Path.Combine(_UrlApi, "SelectRoute"), dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setRoute")]
        public async Task<IActionResult> Post(Route dataModel)
        {
            Route dataReport;
            dataReport = await this.AppContext.Execute<Route>(MethodType.POST, _UrlApi, dataModel);
            return PartialView(string.Concat(_UrlView, "_Index.cshtml"));
        }

        [HttpPost]
        [Route("putRoute")]
        public async Task<JsonResult> Put(Route dataModel)
        {
            dataModel.actualizadopor = User.Identity.Name;
            dataModel.ultimocambio = DateTime.Now;
            await this.AppContext.Execute<Route>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataModel);
        }

        [HttpGet]
        [Route("getRoute/{id}")]
        public async Task<JsonResult> Get(int id, Route dataModel)
        {
            Route dataReport;
            dataReport = await this.AppContext.Execute<Route>(MethodType.GET, string.Concat(_UrlApi, "/getRoute/", id), dataModel);
            return Json(dataReport);
        }

        [HttpGet]
        [Route("AddEdit/{id}")]
        public async Task<IActionResult> AddEditAsync(int id, Route dataModel)
        {
            Cat_Ciudad ciudadModel = new Cat_Ciudad();
            List<Cat_Ciudad> ciudades = await this.AppContext.Execute<List<Cat_Ciudad>>(MethodType.GET, "Catalogs/Geography/City", ciudadModel);
            ciudades.RemoveAll(x => x.estatus == 2);
            ViewBag.CiudadList = new SelectList(ciudades, "id", "nombre");
            Cat_Estado estadoModel = new Cat_Estado();
            List<Cat_Estado> estados = await this.AppContext.Execute<List<Cat_Estado>>(MethodType.GET, "Catalogs/Geography/State", estadoModel);
            estados.RemoveAll(x => x.estatus == 2);
            ViewBag.EstadoList = new SelectList(estados, "id", "nombre");

            if (id > 0)
            {
                dataModel = await this.AppContext.Execute<Route>(MethodType.GET, string.Concat(_UrlApi, "/getRoute/", id), dataModel);

            }
            return PartialView(string.Concat(_UrlView, "_AddEdit.cshtml"), dataModel);
        }
    }
}
