using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models;
using KLS_WEB.Models.Oferta;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KLS_WEB.Controllers.Offer
{
    [Route("Offer/")]
    [Authorize]
    public class OfferController : Controller
    {
        private string _UrlView = "~/Views/Offer/";
        private string _UrlApi = "Offer";
        private readonly IAppContextService AppContext;
        public OfferController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }
        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        //Guardar ofertas masivas
        [HttpPost]
        [Route("setRouteMult")]
        public async Task<JsonResult> setUpdate(Carga dataModel)
        {
            List<Carga> dataGuias;
            dataGuias = await this.AppContext.Execute<List<Carga>>(MethodType.GET, _UrlApi + "/setCarga", dataModel);
            return Json(dataGuias);
        }

        [Route("busqueda")]
        public async Task<JsonResult> Get(ofertas dataModel)
        {
            List<ofertas> dataReport;
            dataReport = await this.AppContext.Execute<List<ofertas>>(MethodType.GET, _UrlApi+ "/busquedas", dataModel);
            return Json(dataReport);
        }

        public class ofertas
        {
            public int idestadoorigen { get; set; }
            public int idestadodestino { get; set; }
            public int idciudadorigen { get; set; }
            public int idciudaddestino { get; set; }
            public int idtipounidad { get; set; }
            public string estadoorigen { get; set; }
            public string ciudadorigen { get; set; }
            public string ciudaddestino { get; set; }
            public string estadodestino { get; set; }
            public string tipounidad { get; set; }
            public string fechadisponibilidad { get; set; }
            public int transportista { get; set; }
            public int estatus { get; set; }
            public int idtransportista { get; set; }

        }
    }
}
