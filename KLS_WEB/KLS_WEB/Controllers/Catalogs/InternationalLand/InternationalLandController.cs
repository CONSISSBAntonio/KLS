using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.InternationalLand
{
    [Route("Catalogs/InternationalLand")]
    [Authorize]
    public class InternationalLandController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/InternationalLand/";
        private string _UrlApi = "Catalogs/InternationalLand";
        
        private readonly IAppContextService AppContext;
        public InternationalLandController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getInternational")]
        public async Task<JsonResult> Get(Cat_Terrestres_Internacionales dataModel)
        {
            List<Cat_Terrestres_Internacionales> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Terrestres_Internacionales>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setInternational")]
        public async Task<JsonResult> Post(Cat_Terrestres_Internacionales dataModel)
        {
            Cat_Terrestres_Internacionales dataReport;
            dataReport = await this.AppContext.Execute<Cat_Terrestres_Internacionales>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putInternational")]
        public async Task<JsonResult> Put(Cat_Terrestres_Internacionales dataModel)
        {
            Cat_Terrestres_Internacionales dataReport;
            dataReport = await this.AppContext.Execute<Cat_Terrestres_Internacionales>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
