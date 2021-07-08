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
    [Route("Clients/Certifications")]
    public class CertificationsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Certifications/";
        private string _UrlApi = "Clients/Certifications";

        private readonly IAppContextService AppContext;

        public CertificationsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getCertifiacions")]
        public async Task<JsonResult> Get(Cl_Has_Certificacion dataModel)
        {
            Cl_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Certificacion>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setCertifiacions")]
        public async Task<JsonResult> Post(Cl_Has_Certificacion dataModel)
        {
            Cl_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Certificacion>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putCertifiacions")]
        public async Task<JsonResult> Put(Cl_Has_Certificacion dataModel)
        {
            Cl_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Certificacion>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
