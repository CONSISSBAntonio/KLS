using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersCertifications
{
    [Route("Carriers/Certifications")]
    [Authorize]
    public class CertificationsController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Certifications/";
        private string _UrlApi = "Carriers/Certifications";

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
        public async Task<JsonResult> Get(Tr_Has_Certificacion dataModel)
        {
            Tr_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Certificacion>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setCertifiacions")]
        public async Task<JsonResult> Post(Tr_Has_Certificacion dataModel)
        {
            Tr_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Certificacion>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putCertifiacions")]
        public async Task<JsonResult> Put(Tr_Has_Certificacion dataModel)
        {
            Tr_Has_Certificacion dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Certificacion>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
