using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Airlines
{
    [Route("Catalogs/Airlines")]
    [Authorize]
    public class AirlinesController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Airlines/";
        private string _UrlApi = "Catalogs/Airlines";

        private readonly IAppContextService AppContext;

        public AirlinesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getAirlines")]
        public async Task<JsonResult> Get(Cat_Aerolinea dataModel)
        {
            List<Cat_Aerolinea> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Aerolinea>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setAirlines")]
        public async Task<JsonResult> Post(Cat_Aerolinea dataModel)
        {
            Cat_Aerolinea dataReport;
            dataReport = await this.AppContext.Execute<Cat_Aerolinea>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putAirlines")]
        public async Task<JsonResult> Put(Cat_Aerolinea dataModel)
        {
            Cat_Aerolinea dataReport;
            dataReport = await this.AppContext.Execute<Cat_Aerolinea>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
