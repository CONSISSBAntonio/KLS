using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersLibrary
{
    [Route("Carriers/Library")]
    [Authorize]
    public class LibraryController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Library/";
        private string _UrlApi = "Carriers/Library";

        private readonly IAppContextService AppContext;

        public LibraryController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getLibrary")]
        public async Task<JsonResult> Get(Tr_Has_Biblioteca dataModel)
        {
            List<Tr_Has_Biblioteca> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Biblioteca>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setLibrary")]
        public async Task<JsonResult> Post(Tr_Has_Biblioteca dataModel)
        {
            Tr_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Biblioteca>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putLibrary")]
        public async Task<JsonResult> Put(Tr_Has_Biblioteca dataModel)
        {
            Tr_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Biblioteca>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
