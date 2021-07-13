using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients.Requirements
{
    [Route("Clients/Requirements")]
    [Authorize]
    public class RequirementsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Requirements/";
        private string _UrlApi = "Clients/Requirements";
        private readonly IAppContextService AppContext;

        public RequirementsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
        [Route("getRequirements")]
        public async Task<JsonResult> Get(Cl_Has_Requisitos dataModel)
        {
            Cl_Has_Requisitos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Requisitos>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setRequirements")]
        public async Task<JsonResult> Post(Cl_Has_Requisitos dataModel)
        {
            Cl_Has_Requisitos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Requisitos>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putRequirements")]
        public async Task<JsonResult> Put(Cl_Has_Requisitos dataModel)
        {
            Cl_Has_Requisitos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Requisitos>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
