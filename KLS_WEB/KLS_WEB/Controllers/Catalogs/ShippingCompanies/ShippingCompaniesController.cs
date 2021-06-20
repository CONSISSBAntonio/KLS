using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.ShippingCompanies
{
    [Route("Catalogs/ShippingCompanies")]
    [Authorize]
    public class ShippingCompaniesController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/ShippingCompanies/";
        private string _UrlApi = "Catalogs/ShippingCompanies";

        private readonly IAppContextService AppContext;
        public ShippingCompaniesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getShipping")]
        public async Task<JsonResult> Get(Cat_Navieras dataModel)
        {
            List<Cat_Navieras> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Navieras>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setShipping")]
        public async Task<JsonResult> Post(Cat_Navieras dataModel)
        {
            Cat_Navieras dataReport;
            dataReport = await this.AppContext.Execute<Cat_Navieras>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putShipping")]
        public async Task<JsonResult> Put(Cat_Navieras dataModel)
        {
            Cat_Navieras dataReport;
            dataReport = await this.AppContext.Execute<Cat_Navieras>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
