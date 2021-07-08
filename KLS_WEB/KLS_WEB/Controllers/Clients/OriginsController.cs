using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Origins")]
    public class OriginsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Origins/";
        private string _UrlApi = "Clients/Origins/";

        private readonly IAppContextService AppContext;

        public OriginsController(IAppContextService _AppContext)
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
