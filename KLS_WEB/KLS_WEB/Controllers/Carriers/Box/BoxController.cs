using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersBox
{
    [Route("Carriers/Box")]
    [Authorize]
    public class BoxController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Box/";
        private string _UrlApi = "Carriers/Box";

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
        public async Task<JsonResult> Get(Tr_Has_Box dataModel)
        {
            Tr_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Box>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setBox")]
        public async Task<JsonResult> Post(Tr_Has_Box dataModel)
        {
            Tr_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Box>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putBox")]
        public async Task<JsonResult> Put(Tr_Has_Box dataModel)
        {
            Tr_Has_Box dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Box>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
