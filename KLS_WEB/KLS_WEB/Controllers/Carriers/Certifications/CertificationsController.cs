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
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
