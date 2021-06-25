using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersContacts
{
    [Route("Carriers/Contacts")]
    [Authorize]
    public class ContactsController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Contacts/";
        private string _UrlApi = "Carriers/Contacts";

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
        public async Task<JsonResult> Get(Tr_Has_Contactos dataModel)
        {
            List<Tr_Has_Contactos> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Contactos>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setContacts")]
        public async Task<JsonResult> Post(Tr_Has_Contactos dataModel)
        {
            Tr_Has_Contactos dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Contactos>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putContacts")]
        public async Task<JsonResult> Put(Tr_Has_Contactos dataModel)
        {
            Tr_Has_Contactos dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Contactos>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
