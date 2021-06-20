using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.CustomsBrokers
{
    [Route("Catalogs/CustomsBrokers")]
    [Authorize]
    public class CustomsBrokersController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/CustomsBrokers/";
        private string _UrlApi = "Catalogs/CustomsBrokers";

        private readonly IAppContextService AppContext;
        public CustomsBrokersController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getCustoms")]
        public async Task<JsonResult> Get(Cat_Agentes_Aduanales dataModel)
        {
            List<Cat_Agentes_Aduanales> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Agentes_Aduanales>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setCustoms")]
        public async Task<JsonResult> Post(Cat_Agentes_Aduanales dataModel)
        {
            Cat_Agentes_Aduanales dataReport;
            dataReport = await this.AppContext.Execute<Cat_Agentes_Aduanales>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putCustoms")]
        public async Task<JsonResult> Put(Cat_Agentes_Aduanales dataModel)
        {
            Cat_Agentes_Aduanales dataReport;
            dataReport = await this.AppContext.Execute<Cat_Agentes_Aduanales>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
