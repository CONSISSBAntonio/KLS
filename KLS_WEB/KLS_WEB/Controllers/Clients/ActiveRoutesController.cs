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
    [Route("Clients/ActiveRoutes")]
    public class ActiveRoutesController : Controller
    {
        private string _UrlView = "~/Views/Clients/ActiveRoutes/";
        private string _UrlApi = "Clients/ActiveRoutes";
        private readonly IAppContextService AppContext;
        public ActiveRoutesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
        //Metodos de api
        [Route("getRutas")]
        public async Task<JsonResult> getRuta(Cl_Has_Routes dataModel)
        {
            List<Cl_Has_Routes> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Routes>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }
        [Route("setRoutes")]
        public async Task<JsonResult> Post(Cl_Has_Routes dataModel)
        {
            Cl_Has_Routes dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Routes>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }
        [Route("putRoutes")]
        public async Task<JsonResult> Put(Cl_Has_Routes dataModel)
        {
            Cl_Has_Routes dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Routes>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
        //Actualizado 05/08/2021
        [Route("getRoute")]
        public async Task<JsonResult> getRoutes(Cl_Has_Routes routes)
        {
            List<clRoutes> dataReport;
            dataReport = await this.AppContext.Execute< List<clRoutes>>(MethodType.GET, _UrlApi+"/getRoute", routes);
            return Json(dataReport);
        }
        public class clRoutes
        {
            public int id { get; set; }
            public int idcliente { get; set; }
            public int idorigen { get; set; }
            public string origen { get; set; }
            public int iddestino { get; set; }
            public string destino { get; set; }
            public int tiemporuta { get; set; }
            public bool monitoreable { get; set; }
            public int status { get; set; }
            public int idcorigen { get; set; }
            public int idcdestino { get; set; }
            public int idruta { get; set; }
        }

        [Route("getRoutes")]
        public async Task<JsonResult> getRoutes(Route routes)
        {
            List<routeActives> dataReport;
            dataReport = await this.AppContext.Execute< List<routeActives>>(MethodType.GET, _UrlApi+ "/getRoutes", routes);
            return Json(dataReport);
        }

        public class routeActives
        {
            public int id { get; set; }
            public int idestadoorigen { get; set; }
            public int idciudadorigen { get; set; }
            public int idestadodestino { get; set; }
            public int idciudaddestino { get; set; }
            public string estadoOrigen { get; set; }
            public string ciudadOrigen { get; set; }
            public string estadoDestino { get; set; }
            public string ciudadDestino { get; set; }
        }

    }
}
