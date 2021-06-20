using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Coloaders
{
    [Route("Catalogs/Coloaders")]
    [Authorize]
    public class ColoadersController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Coloaders/";
        private string _UrlApi = "Catalogs/Coloaders";

        private readonly IAppContextService AppContext;
        public ColoadersController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getColoaders")]
        public async Task<JsonResult> Get(Cat_Coloaders dataModel)
        {
            List<Cat_Coloaders> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Coloaders>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setColoaders")]
        public async Task<JsonResult> Post(Cat_Coloaders dataModel)
        {
            Cat_Coloaders dataReport;
            dataReport = await this.AppContext.Execute<Cat_Coloaders>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putColoaders")]
        public async Task<JsonResult> Put(Cat_Coloaders dataModel)
        {
            Cat_Coloaders dataReport;
            dataReport = await this.AppContext.Execute<Cat_Coloaders>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
