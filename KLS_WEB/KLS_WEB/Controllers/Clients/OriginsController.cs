using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Origins")]
    public class OriginsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Origins/";
        private string _UrlApi = "Clients/Origins/";

        private readonly IAppContextService AppContext;

        public OriginsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getOrigen")]
        public async Task<JsonResult> Get(Cl_Has_Origen dataModel)
        {
            List<dest> dataReport;
            dataReport = await this.AppContext.Execute<List<dest>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        public class dest
        {
            public string nombre { get; set; }
            public string cp { get; set; }
            public string estado { get; set; }
            public string ciudad { get; set; }
            public string direccion { get; set; }
            public string estatus { get; set; }
            public int id { get; set; }
        }

        [Route("setOrigen")]
        public async Task<JsonResult> Post(Cl_Has_Origen dataModel)
        {
            Cl_Has_Origen dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Origen>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putOrigen")]
        public async Task<JsonResult> Put(Cl_Has_Origen dataModel)
        {
            Cl_Has_Origen dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Origen>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("[action]/{Id}")]
        public async Task<JsonResult> GetOrigin(string Id)
        {
            Cl_Has_Origen origen = await AppContext.Execute<Cl_Has_Origen>(MethodType.GET, Path.Combine(_UrlApi, "GetOrigin", Id), null);
            return Json(origen);
        }
        
        [Route("getColonias/{Id}")]
        public async Task<JsonResult> getColonias(string Id)
        {
            List<Cat_Colonia> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Colonia>>(MethodType.GET, Path.Combine(_UrlApi, "getColonias", Id), null);
            return Json(dataReport);
        }
        [Route("getCp/{cp}")]
        public async Task<JsonResult> getCp(string cp)
        {
            List<Cat_Colonia> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Colonia>>(MethodType.GET, Path.Combine(_UrlApi, "getCp", cp), null);
            return Json(dataReport);
        }
    }
}
