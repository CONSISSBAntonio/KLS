using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersOperators
{
    [Route("Carriers/Operators")]
    [Authorize]
    public class OperatorsController : Controller
    {
        
        private string _UrlView = "~/Views/Carriers/Operators/";
        private string _UrlApi = "Carriers/Operators";

        private readonly IAppContextService AppContext;

        public OperatorsController(IAppContextService _AppContext)
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
