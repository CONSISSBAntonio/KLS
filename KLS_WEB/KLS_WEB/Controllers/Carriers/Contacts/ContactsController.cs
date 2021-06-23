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
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
