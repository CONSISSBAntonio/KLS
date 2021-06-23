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
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
