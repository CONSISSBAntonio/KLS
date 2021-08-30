using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Destinations")]
    [Authorize]
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
            public int id_Estado { get; set; }
            public int id_Ciudad { get; set; }
            public int id_Colonia { get; set; }
            public int id { get; set; }
            public string HoraAtencion { get; set; }
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

        [Route("[action]/{Id}")]
        public async Task<JsonResult> GetDestination(string Id)
        {
            Cl_Has_Destinos destino = await AppContext.Execute<Cl_Has_Destinos>(MethodType.GET, Path.Combine(_UrlApi, "GetDestination", Id), null);
            return Json(destino);
        }

    }
}
