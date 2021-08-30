using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Contacts")]
    [Authorize]
    public class ContactsController : Controller
    {
        private string _UrlView = "~/Views/Clients/Contacts/";
        private string _UrlApi = "Clients/Contacts";

        private readonly IAppContextService AppContext;

        public ContactsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }
        [Route("getContacts")]
        public async Task<JsonResult> Get(Cl_Has_Contactos dataModel)
        {
            List<Cl_Has_Contactos> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Contactos>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setContacts")]
        public async Task<JsonResult> Post(Cl_Has_Contactos dataModel)
        {
            Cl_Has_Contactos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Contactos>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putContacts")]
        public async Task<JsonResult> Put(Cl_Has_Contactos dataModel)
        {
            Cl_Has_Contactos dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Contactos>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
