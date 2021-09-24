using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
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
            dataReport = await this.AppContext.Execute<List<Route>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("getRuta")]
        public async Task<JsonResult> getRuta(RouteTran dataModel)
        {
            List<Ruta> dataReport;
            dataReport = await this.AppContext.Execute<List<Ruta>>(MethodType.GET, _UrlApi + "/getRuta", dataModel);
            return Json(dataReport);
        }

        [Route("getRutas")]
        public async Task<JsonResult> getRuta(Tr_Has_Rutas dataModel)
        {
            List<Tr_Has_Rutas> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Rutas>>(MethodType.GET, _UrlApi, dataModel);
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

        public class TravelServicePrice
        {
            public int CarrierRouteId { get; set; }
            public int TravelServiceId { get; set; }
            public decimal OneWayPrice { get; set; }
            public decimal TwoWayPrice { get; set; }
            public decimal CircuiteablePrice { get; set; }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<JsonResult> AddEditInventario([FromBody] ICollection<TravelServicePrice> travelServicePrices)
        {
            var response = await AppContext.Execute<List<TravelServicePrice>>(MethodType.POST, Path.Combine(_UrlApi, "AddEditTravelServicePrice"), travelServicePrices);
            return Json(response);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<JsonResult> GetRutaInventario(string Tr_Has_RutaId)
        {
            var rutaInventario = await AppContext.Execute<List<ruta_has_inventario>>(MethodType.GET, Path.Combine(_UrlApi, "GetRutaInventario", Tr_Has_RutaId), null);
            return Json(rutaInventario);
        }

        [Route("obRutas")]
        public async Task<JsonResult> obRutas()
        {
            List<Route> dataReport;
            dataReport = await this.AppContext.Execute<List<Route>>(MethodType.GET, _UrlApi + "/obRutas", null);
            return Json(dataReport);
        }
    }
}
