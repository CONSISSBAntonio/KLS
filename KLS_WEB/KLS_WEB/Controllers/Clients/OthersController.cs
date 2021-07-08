using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Others")]
    public class OthersController : Controller
    {
        private string _UrlView = "~/Views/Clients/Others/";
        private string _UrlApi = "Clients/Others/";

        private readonly IAppContextService AppContext;

        public OthersController(IAppContextService _AppContext)
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
