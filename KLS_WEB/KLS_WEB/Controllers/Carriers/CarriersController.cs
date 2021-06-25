using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers
{
    [Route("Carriers/")]
    [Authorize]
    public class CarriersController : Controller
    {
        private string _UrlView = "~/Views/Carriers/";
        private string _UrlApi = "Carriers";

        private readonly IAppContextService AppContext;

        public CarriersController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
        
        [Route("formCarriers/{id=0}")]
        public IActionResult formCarriers(int id = 0)
        {
            ViewBag.id = id;
            return View(this._UrlView + "formCarriers.cshtml");
        }

        //Servicios
        [Route("getCarriers")]
        public async Task<JsonResult> Get(Transportista dataModel)
        {
            List<Transportista> dataReport;
            dataReport = await this.AppContext.Execute<List<Transportista>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setCarriers")]
        public async Task<JsonResult> Post(Transportista dataModel)
        {
            Transportista dataReport;
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }
        
        [Route("putCarriers")]
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
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.GET, _UrlApi+ "/getCarrier", dataModel);
            return Json(dataReport);
        }

    }
}
