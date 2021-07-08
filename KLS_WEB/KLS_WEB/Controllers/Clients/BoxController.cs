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
    [Route("Clients/Box")]
    public class BoxController : Controller
    {
        private string _UrlView = "~/Views/Clients/Box/";
        private string _UrlApi = "Clients/Box";

        private readonly IAppContextService AppContext;

        public BoxController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getBox")]
        public async Task<JsonResult> Get(Cl_Has_Box dataModel)
        {
            Cl_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Box>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setBox")]
        public async Task<JsonResult> Post(Cl_Has_Box dataModel)
        {
            Cl_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Box>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putBox")]
        public async Task<JsonResult> Put(Cl_Has_Box dataModel)
        {
            Cl_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Box>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
