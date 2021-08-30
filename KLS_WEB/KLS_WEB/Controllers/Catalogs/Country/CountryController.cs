using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Country
{
    [Route("Catalogs/Geography/Country")]
    [Authorize]
    public class CountryController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Country/";
        private string _UrlApi = "Catalogs/Geography/Country";

        private readonly IAppContextService AppContext;

        public CountryController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getCountry")]
        public async Task<JsonResult> Get(Cat_Pais dataModel)
        {
            List<Cat_Pais> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Pais>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setCountry")]
        public async Task<JsonResult> Post(Cat_Pais dataModel)
        {
            Cat_Pais dataReport;
            dataReport = await this.AppContext.Execute<Cat_Pais>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putCountry")]
        public async Task<JsonResult> Put(Cat_Pais dataModel)
        {
            Cat_Pais dataReport;
            dataReport = await this.AppContext.Execute<Cat_Pais>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
