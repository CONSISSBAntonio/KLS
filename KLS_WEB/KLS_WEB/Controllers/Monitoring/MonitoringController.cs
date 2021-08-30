using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Monitoring
{
    [Route("Monitoring")]
    [Authorize]
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

        [Route("getMonitoring")]
        public async Task<JsonResult> Get()
        {
            List<Monitoring> dataMonitoring;
            dataMonitoring = await this.AppContext.Execute<List<Monitoring>>(MethodType.GET, _UrlApi, null);
            return Json(dataMonitoring);
        }

        public class Monitoring {
            public string folio { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public string  fechallegada {get;set;}
            public string fechallegada_ { get;set;}
            public string estatus { get; set; }
            public int idviaje { get; set; }
            public string cliente { get; set; }
        }

        [Route("getClient")]
        public async Task<JsonResult> getClient()
        {
            List<Clientes> dataClient;
            dataClient = await this.AppContext.Execute<List<Clientes>>(MethodType.GET, _UrlApi+"/getClient", null);
            return Json(dataClient);
        }
        
        [Route("getStatus")]
        public async Task<JsonResult> getStatus()
        {
            List<Status> dataClient;
            dataClient = await this.AppContext.Execute<List<Status>>(MethodType.GET, _UrlApi+ "/getStatus", null);
            return Json(dataClient);
        }
        [Route("getSubStatus")]
        public async Task<JsonResult> getSubStatus()
        {
            List<Substatus> dataClient;
            dataClient = await this.AppContext.Execute<List<Substatus>>(MethodType.GET, _UrlApi+ "/getSubStatus", null);
            return Json(dataClient);
        }
    }
}
