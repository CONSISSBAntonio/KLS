using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Travels
{
    [Route("Travels/")]
    [Authorize]
    public class TravelsController : Controller
    {
        private string _UrlView = "~/Views/Travels/";
        private string _UrlApi = "Travels";

        private readonly IAppContextService AppContext;

        public TravelsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "Index.cshtml");
        }

        [Route("formTravels/{id=0}")]
        public IActionResult formTravels(int id = 0)
        {
            ViewBag.id = id;
            return View(this._UrlView + (id == 0 ? "New.cshtml" : "Details.cshtml"));
        }

        //Servicios
        [Route("getTravels")]
        public async Task<JsonResult> Get(Transportista dataModel)
        {
            List<Transportista> dataReport;
            dataReport = await this.AppContext.Execute<List<Transportista>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setTravels")]
        public async Task<JsonResult> Post(Transportista dataModel)
        {
            Transportista dataReport;
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putTravels")]
        public async Task<JsonResult> Put(Transportista dataModel)
        {
            Transportista dataReport;
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpGet]
        [Route("getCarrier")]
        public async Task<JsonResult> getCarrier(Transportista dataModel)
        {
            Transportista dataReport;
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.GET, _UrlApi + "/getCarrier", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        public PartialViewResult ReturnServicios(Travel travel)
        {
            return PartialView(string.Concat(_UrlView, "_Servicios.cshtml"), travel);
        }

    }
}
