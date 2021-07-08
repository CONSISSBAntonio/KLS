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
    }
}
