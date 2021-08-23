using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Subservices
{
    [Route("Catalogs/Subservices")]
    [Authorize]
    public class SubservicesController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Subservices/";
        private string _UrlApi = "Catalogs/Subservices";

        private readonly IAppContextService AppContext;
        public SubservicesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getSubservices")]
        public async Task<JsonResult> Get(Cat_Subservicios dataModel)
        {
            List<Cat_Subservicios> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Subservicios>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }
        [HttpPost]
        [Route("setSubservices")]
        public async Task<JsonResult> Post(Cat_Subservicios dataModel)
        {
            Cat_Subservicios dataReport;
            dataReport = await this.AppContext.Execute<Cat_Subservicios>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putSubservices")]
        public async Task<JsonResult> Put(Cat_Subservicios dataModel)
        {
            Cat_Subservicios dataReport;
            dataReport = await this.AppContext.Execute<Cat_Subservicios>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
