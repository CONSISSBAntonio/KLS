using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models.Search;
using KLS_WEB.Models.Demand;
using KLS_WEB.Services;
using KLS_WEB.Models;
using System.IO;
using KLS_WEB.Models.DT;

namespace KLS_WEB.Controllers.Demand
{
    public class DemandController : Controller
    {
        private string _UrlView = "~/Views/Demand/";
        private string _UrlApi = "Demands";

        private readonly IAppContextService AppContext;

        public DemandController(IAppContextService _AppContext)
        {
            AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> SetDemand(DemandDTO model)
        {
            DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.POST, Path.Combine(_UrlApi, "SetDemand"), model);

            return Json(demand);
        }

        [HttpPost]
        public async Task<JsonResult> DT(DataTablesParameters dtParams) {
            DTModel data = await AppContext.Execute<DTModel>(MethodType.POST, Path.Combine(_UrlApi, "DT"), dtParams);

            return Json(data);
        }

        [HttpGet]
        public async Task<JsonResult> GetDemand(string Id)
        {
            DemandDTO demand = await AppContext.Execute<DemandDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetDemand", Id), null);
            return Json(demand);
        }

        //[HttpPost]
        //public async Task<JsonResult> Search(SearchModel search)
        //{
        //    List<DemandDTO> result = await AppContext.Execute<List<DemandDTO>>(MethodType.GET, Path.Combine(_UrlApi, "Search"), search);

        //    return Json(result);
        //}
    }
}
