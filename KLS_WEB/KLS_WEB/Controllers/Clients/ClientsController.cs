using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/")]
    [Authorize]
    public class ClientsController : Controller
    {
        private string _UrlView = "~/Views/Clients/";
        private string _UrlApi = "Clients";
        private readonly IAppContextService AppContext;
        public ClientsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("formClients/{id=0}")]
        public IActionResult formCarriers(int id = 0)
        {
            ViewBag.id = id;
            return View(this._UrlView + "formClients.cshtml");
        }

        //Servicios
        [Route("getClients")]
        public async Task<JsonResult> Get(Clientes dataModel)
        {
            List<Clientes> dataReport;
            dataReport = await this.AppContext.Execute<List<Clientes>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setClients")]
        public async Task<JsonResult> Post(Clientes dataModel)
        {
            Clientes dataReport;
            dataReport = await this.AppContext.Execute<Clientes>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putClients")]
        public async Task<JsonResult> Put(Clientes dataModel)
        {
            Clientes dataReport;
            dataReport = await this.AppContext.Execute<Clientes>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpGet]
        [Route("getClient")]
        public async Task<JsonResult> getCarrier(Clientes dataModel)
        {
            Clientes dataReport;
            dataReport = await this.AppContext.Execute<Clientes>(MethodType.GET, _UrlApi + "/getClient", dataModel);
            return Json(dataReport);
        }
    }
}
