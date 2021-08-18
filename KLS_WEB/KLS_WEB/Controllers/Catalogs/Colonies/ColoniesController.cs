using KLS_API.Models;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models.DT;
using System.IO;

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
            public List<Cat_Colonia> colonias { get; set; }
            public double total { get; set; }
        };

        [Route("getColonies")]
        public async Task<JsonResult> Get(Cat_Colonia colonia)
        {
            List<Cat_Colonia> dataReport;
            dataReport = await this.AppContext.Execute<List<Cat_Colonia>>(MethodType.GET, _UrlApi, colonia);
            return Json(dataReport);
        }

        [Route("getColoniesF")]
        public async Task<IActionResult> Get(Paginacion paginacion)
        {
            colonia dataReport;
            dataReport = await this.AppContext.Execute<colonia>(MethodType.GET, _UrlApi + "/prueba?Pagina=" + paginacion.Pagina + "&CantidadAMostrar=" + paginacion.CantidadAMostrar, paginacion);
            return Ok(dataReport);
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

        [HttpPost]
        [Route("[action]")]
        public async Task<JsonResult> DT(DataTablesParameters param)
        {
            IEnumerable<ColoniaDT> colonias = await AppContext.Execute<List<ColoniaDT>>(MethodType.GET, Path.Combine(_UrlApi, "DT"), null);

            long total = colonias.Count();

            #region Búsqueda
            if (!string.IsNullOrEmpty(param.search.value[0]))
            {
                string keyword = param.search.value[0].ToLower();
                colonias = colonias.Where(x => x.Nombre.ToLower().Contains(keyword) ||
                x.Estado.ToLower().Contains(keyword) ||
                x.Ciudad.ToLower().Contains(keyword) ||
                x.CP.ToString().Contains(keyword));
            }

            long totalFiltered = colonias.Count();
            #endregion

            #region Ordenamiento
            int columnId = param.order[0].column[0];

            Func<ColoniaDT, string> orderFunction = (x => columnId == 0 ? x.Estado :
            columnId == 1 ? x.Ciudad :
            columnId == 2 ? x.CP.ToString() : x.Nombre);

            if (param.order[0].dir[0] == "asc")
            {
                colonias = colonias.OrderBy(orderFunction);
            }
            else
            {
                colonias = colonias.OrderByDescending(orderFunction);
            }
            #endregion

            #region Paginado
            colonias.Skip(param.start).Take(param.length);
            #endregion

            #region DataTable
            List<ColoniaDT> data = colonias.Select(x => new ColoniaDT
            {
                Id = x.Id,
                Estado = x.Estado,
                Ciudad = x.Ciudad,
                CP = x.CP,
                Nombre = x.Nombre,
                Estatus = x.Estatus
            }).ToList();
            #endregion

            return Json(new
            {
                aaData = data,
                param.draw,
                iTotalRecords = total,
                iTotalDisplayRecords = totalFiltered
            });
        }
    }
}
