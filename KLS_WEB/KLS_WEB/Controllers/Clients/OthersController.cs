using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Others")]
    [Authorize]
    public class OthersController : Controller
    {
        private string _UrlView = "~/Views/Clients/Others/";
        private string _UrlApi = "Clients/Others/";

        private readonly IAppContextService AppContext;

        public OthersController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
        [Route("getEvidencia")]
        public async Task<JsonResult> Get(Cl_Has_Evidencia dataModel)
        {
            List<Cl_Has_Evidencia> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Evidencia>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setEvidencia")]
        public async Task<JsonResult> Post(Cl_Has_Evidencia dataModel)
        {
            Cl_Has_Evidencia dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Evidencia>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putEvidencia")]
        public async Task<JsonResult> Put(Cl_Has_Evidencia dataModel)
        {
            Cl_Has_Evidencia dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Evidencia>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        //------------------------------------------------------Otros
        [Route("getOtros")]
        public async Task<JsonResult> getOtros(Cl_Has_Otros dataModel)
        {
            Cl_Has_Otros dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Otros>(MethodType.GET, _UrlApi + "getOtros", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setOtros")]
        public async Task<JsonResult> setOtros(Cl_Has_Otros dataModel)
        {
            Cl_Has_Otros dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Otros>(MethodType.POST, _UrlApi + "setOtros", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putOtros")]
        public async Task<JsonResult> putOtros(Cl_Has_Otros dataModel)
        {
            Cl_Has_Otros dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Otros>(MethodType.PUT, _UrlApi + "putOtros", dataModel);
            return Json(dataReport);
        }

    }
}
