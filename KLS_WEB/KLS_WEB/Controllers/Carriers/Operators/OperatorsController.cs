using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersOperators
{
    [Route("Carriers/Operators")]
    [Authorize]
    public class OperatorsController : Controller
    {
        
        private string _UrlView = "~/Views/Carriers/Operators/";
        private string _UrlApi = "Carriers/Operators";

        private readonly IAppContextService AppContext;

        public OperatorsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getOperators")]
        public async Task<JsonResult> Get(Tr_Has_Operadores dataModel)
        {
            List<Tr_Has_Operadores> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Operadores>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }
        
        [Route("[action]/{id}")]
        public async Task<JsonResult> GetOperator(string id)
        {
            Tr_Has_Operadores operador = new Tr_Has_Operadores();
            Tr_Has_Operadores data = await AppContext.Execute<Tr_Has_Operadores>(MethodType.GET, Path.Combine(_UrlApi, "GetOperator", id), operador);
            return Json(data);
        }

        [Route("setOperators")]
        public async Task<JsonResult> Post(Tr_Has_Operadores dataModel)
        {
            Tr_Has_Operadores dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("putOperators")]
        public async Task<JsonResult> Put(Tr_Has_Operadores dataModel)
        {
            Tr_Has_Operadores dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
