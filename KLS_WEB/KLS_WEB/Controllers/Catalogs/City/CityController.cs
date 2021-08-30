using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Views.Catalogs.City
{
    [Route("Catalogs/Geography/City")]
    [Authorize]
    public class CityController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/City/";
        private string _UrlApi = "Catalogs/Geography/City";
        private readonly IAppContextService AppContext;
        public CityController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getCity")]
        public async Task<JsonResult> Get(Cat_Ciudad dataModel)
        {
            List<Cat_Ciudad> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Ciudad>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setCity")]
        public async Task<JsonResult> Post(Cat_Ciudad dataModel)
        {
            Cat_Ciudad dataReport;
            dataReport = await this.AppContext.Execute<Cat_Ciudad>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putCity")]
        public async Task<JsonResult> Put(Cat_Ciudad dataModel)
        {
            Cat_Ciudad dataReport;
            dataReport = await this.AppContext.Execute<Cat_Ciudad>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
