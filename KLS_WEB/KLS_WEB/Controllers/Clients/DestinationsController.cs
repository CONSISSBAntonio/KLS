using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Destinations")]
    public class DestinationsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Destinations/";
        private string _UrlApi = "Clients/Destinations/";

        private readonly IAppContextService AppContext;

        public DestinationsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
    }
}
