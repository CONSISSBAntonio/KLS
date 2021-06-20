using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Colonies
{
    [Route("Catalogs/Geography/Colonies")]
    public class ColoniesController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Colonies/";
        private string _UrlApi = "Catalogs/Geography/Colonies";

        private readonly IAppContextService AppContext;
        public ColoniesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getColonies")]
        public async Task<JsonResult> Get(Cat_Colonia dataModel)
        {
            List<Cat_Colonia> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Colonia>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setColonies")]
        public async Task<JsonResult> Post(Cat_Colonia dataModel)
        {
            Cat_Colonia dataReport;
            dataReport = await this.AppContext.Execute<Cat_Colonia>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putColonies")]
        public async Task<JsonResult> Put(Cat_Colonia dataModel)
        {
            Cat_Colonia dataReport;
            dataReport = await this.AppContext.Execute<Cat_Colonia>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
