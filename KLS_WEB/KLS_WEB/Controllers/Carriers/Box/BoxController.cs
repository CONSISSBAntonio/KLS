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
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
