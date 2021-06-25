using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersInventory
{
    [Route("Carriers/Inventory")]
    [Authorize]
    public class InventoryController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Inventory/";
        private string _UrlApi = "Carriers/Inventory";

        private readonly IAppContextService AppContext;

        public InventoryController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
    }
}
