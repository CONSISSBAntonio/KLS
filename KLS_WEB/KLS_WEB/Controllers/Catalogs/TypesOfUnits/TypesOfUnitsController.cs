using KLS_WEB.Models;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.TypesOfUnits
{
    [Route("Catalogs/TypesOfUnits")]
    [Authorize]
    public class TypesOfUnitsController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/TypesOfUnits/";
        private string _UrlApi = "Catalogs/TypesOfUnits";

        private readonly IAppContextService AppContext;
        public TypesOfUnitsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getUnidades")]
        public async Task<JsonResult> Get(Cat_Tipos_Unidades dataModel)
        {
            List<Cat_Tipos_Unidades> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Tipos_Unidades>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("getTravelServices")]
        public async Task<JsonResult> GetTravelServices()
        {
            ICollection<TravelService> travelServices = await AppContext.Execute<List<TravelService>>(MethodType.GET, Path.Combine(_UrlApi, "GetTravelServices"), null);
            return Json(travelServices);
        }

        [Route("setUnidades")]
        public async Task<JsonResult> Post(Cat_Tipos_Unidades dataModel)
        {
            Cat_Tipos_Unidades dataReport;
            dataReport = await this.AppContext.Execute<Cat_Tipos_Unidades>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putUnidades")]
        public async Task<JsonResult> Put(Cat_Tipos_Unidades dataModel)
        {
            Cat_Tipos_Unidades dataReport;
            dataReport = await this.AppContext.Execute<Cat_Tipos_Unidades>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
