using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Checkpoints")]
    [Authorize]
    public class CheckpointsController : Controller
    {
        private string _UrlView = "~/Views/Clients/ActiveRoutes/";
        private string _UrlApi = "Clients/Checkpoints";

        private readonly IAppContextService AppContext;

        public CheckpointsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        [Route("{id=0}/{idruta=0}")]
        public IActionResult Index(int id, int idruta)
        {
            ViewBag.id = id;
            ViewBag.idruta = idruta;
            return View(this._UrlView + "Checkpoints.cshtml");
        }
        [Route("getCheckpoints")]
        public async Task<JsonResult> getRuta(Cl_Has_Checkpoint dataModel)
        {
            List<Cl_Has_Checkpoint> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Checkpoint>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [Route("setCheckpoints")]
        public async Task<JsonResult> Post(Cl_Has_Checkpoint dataModel)
        {
            Cl_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Checkpoint>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }
        [Route("putCheckpoints")]
        public async Task<JsonResult> Put(Cl_Has_Checkpoint dataModel)
        {
            Cl_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Checkpoint>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

    }
}
