using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Colonies
{
    [Route("Catalogs/Geography/Colonies")]
    public class ColoniesController : Controller
    {
        private string _UrlView = "~/Views/Catalogs/Colonies/";
        private string _UrlApi = "Catalogs/Geography/Colonies";

        private readonly IAppContextService AppContext;
        public ColoniesController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }
        class colonia
        {
            public List<colonias> colonias { get; set; }
            public int total { get; set; }
        };

        class colonias
        { 
            public int id { get; set; }
            public int id_estado { get; set; }
            public int id_ciudad { get; set; }
            public string cp { get; set; }
            public string nombre { get; set; }
            public int estatus { get; set; }
        }

        [Route("getColonies")]
        public async Task<JsonResult> Get(Paginacion paginacion)
        {
            colonia dataReport;
            dataReport = await this.AppContext.Execute<colonia>(MethodType.GET, _UrlApi+ "/prueba?Pagina="+paginacion.Pagina+"&CantidadAMostrar="+paginacion.CantidadAMostrar, null);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setColonies")]
        public async Task<JsonResult> Post(Cat_Colonia dataModel)
        {
            Cat_Colonia dataReport;
            dataReport = await this.AppContext.Execute<Cat_Colonia>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("putColonies")]
        public async Task<JsonResult> Put(Cat_Colonia dataModel)
        {
            Cat_Colonia dataReport;
            dataReport = await this.AppContext.Execute<Cat_Colonia>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
