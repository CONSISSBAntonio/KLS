using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
