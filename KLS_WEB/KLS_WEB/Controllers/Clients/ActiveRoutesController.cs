using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/ActiveRoutes")]
    public class ActiveRoutesController : Controller
    {
        private string _UrlView = "~/Views/Clients/ActiveRoutes/";
        private string _UrlApi = "Clients/ActiveRoutes";

        private readonly IAppContextService AppContext;

        public ActiveRoutesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
        //Metodos de api
        [Route("getRutas")]
        public async Task<JsonResult> getRuta(Cl_Has_Routes dataModel)
        {
            List<Cl_Has_Routes> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Routes>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setRoutes")]
        public async Task<JsonResult> Post(Cl_Has_Routes dataModel)
        {
            Cl_Has_Routes dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Routes>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }
        [Route("putRoutes")]
        public async Task<JsonResult> Put(Cl_Has_Routes dataModel)
        {
            Cl_Has_Routes dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Routes>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
