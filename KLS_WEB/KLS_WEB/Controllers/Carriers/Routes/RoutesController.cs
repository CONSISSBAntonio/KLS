using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersRoutes
{
    [Route("Carriers/Routes")]
    [Authorize]
    public class RoutesController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Routes/";
        private string _UrlApi = "Carriers/Routes";

        private readonly IAppContextService AppContext;

        public RoutesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
