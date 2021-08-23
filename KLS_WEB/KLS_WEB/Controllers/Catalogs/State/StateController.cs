using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.State
{
    [Route("Catalogs/Geography/State")]
    public class StateController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/State/";
        private string _UrlApi = "Catalogs/Geography/State";
        private readonly IAppContextService AppContext;
        public StateController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getState")]
        public async Task<JsonResult> Get(Cat_Estado dataModel)
        {
            List<Cat_Estado> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Estado>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setState")]
        public async Task<JsonResult> Post(Cat_Estado dataModel)
        {
            Cat_Estado dataReport;
            dataReport = await this.AppContext.Execute<Cat_Estado>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putState")]
        public async Task<JsonResult> Put(Cat_Estado dataModel)
        {
            Cat_Estado dataReport;
            dataReport = await this.AppContext.Execute<Cat_Estado>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
