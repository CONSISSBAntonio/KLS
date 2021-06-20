using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Regions
{
    [Route("Catalogs/Geography/Regions")]
    [Authorize]
    public class RegionsController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Regions/";
        private string _UrlApi = "Catalogs/Geography/Regions";

        private readonly IAppContextService AppContext;

        public RegionsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
          
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [HttpPost]
        [Route("setRegion")]
        public async Task<JsonResult> Post( Cat_Region dataModel)
        {
            Cat_Region dataReport;
            dataReport = await this.AppContext.Execute<Cat_Region>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("getRegion")]
        public async Task<JsonResult> Get(Cat_Region dataModel)
        {
            List<Cat_Region> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Region>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putRegion")]
        public async Task<JsonResult> Put(Cat_Region dataModel)
        {
            Cat_Region dataReport;
            dataReport = await this.AppContext.Execute<Cat_Region>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
