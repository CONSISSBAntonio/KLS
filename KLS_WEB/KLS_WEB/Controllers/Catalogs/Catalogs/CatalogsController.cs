using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs
{
    [Route("Catalogs")]
    [Authorize]
    public class CatalogsController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Catalogs/";
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
        
        [Route("Geografia")]
        public IActionResult Geografia()
        {
            return View(this._UrlView + "GeografiaViews.cshtml");
        }
    }
}
