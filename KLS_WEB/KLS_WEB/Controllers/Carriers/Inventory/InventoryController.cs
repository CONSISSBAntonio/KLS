using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
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
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getInventory")]
        public async Task<JsonResult> Get(Tr_Has_Inventario dataModel)
        {
            List<Tr_Has_Inventario> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Inventario>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setInventory")]
        public async Task<JsonResult> Post(Tr_Has_Inventario dataModel)
        {
            Tr_Has_Inventario dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putInventory")]
        public async Task<JsonResult> Put(Tr_Has_Inventario dataModel)
        {
            Tr_Has_Inventario dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
