using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Monitoring
{
    [Route("Monitoring")]
    public class MonitoringController : Controller
    {
        private string _UrlView = "~/Views/Monitoring/";
        private string _UrlApi = "Monitoring";

        private readonly IAppContextService AppContext;

        public MonitoringController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(_UrlView + "/index.cshtml");
        }
    }
}
