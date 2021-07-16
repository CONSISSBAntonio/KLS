using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Offer
{
    [Route("Offer/")]
    [Authorize]
    public class OfferController : Controller
    {
        private string _UrlView = "~/Views/Offer/";
        private string _UrlApi = "Offer";
        private readonly IAppContextService AppContext;
        public OfferController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
