using KLS_WEB.Models;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KLS_WEB.Controllers.Travels
{
    [Route("Facturacion")]
    [Authorize]
    public class FacturacionController : Controller
    {
        #region properties
        private string _UrlView = "~/Views/Travels/";
        private string _UrlApi = "Travels/Facturacion";
        private readonly IAppContextService _appContext;
        private readonly IWebHostEnvironment _hostingEnvironment;
        
        #endregion

        #region constructor
        public FacturacionController(IAppContextService appContext, IWebHostEnvironment hostingEnvironment)
        {
            _appContext = appContext;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region Methods
        [HttpGet]
        [Route("getFacturas")]
        public async Task<JsonResult> Get()
        {
            Facturacion facturas = new Facturacion();
            var result = await _appContext.Execute<Facturacion>(MethodType.GET,_UrlApi,facturas);
            return Json(result);
        }

        [HttpPost]
        //[Route("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                //string projectRootPath = _hostingEnvironment.ContentRootPath; ruta del poryecto
                string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"\Resources\Facturas\");
                string fullpath = Path.Combine(ruta, file.FileName);
                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);

                var isSaved = SaveFile(file, fullpath);               

                Facturacion facturacion = new Facturacion()
                {
                    nombre = file.FileName,
                    fullpath = fullpath,
                    fechacarga = DateTime.Today,
                    usuarioId = 1,
                    usuario = "Daniel"
                };

                if (isSaved)
                {
                    var result = await _appContext.Execute<Facturacion>(MethodType.POST, _UrlApi, facturacion);
                    return Ok(result);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool SaveFile(IFormFile file, string fullpath)
        {
            if (file is null)
                return false;          
                        
            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }
            return true;            
        }
        #endregion       
    }
}
