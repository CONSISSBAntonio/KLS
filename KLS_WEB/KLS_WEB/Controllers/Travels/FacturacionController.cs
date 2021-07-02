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
using IoFile = System.IO.File;

namespace KLS_WEB.Controllers.Travels
{
    [Route("Facturacion")]
    [Authorize]
    public class FacturacionController : Controller
    {
        #region properties
        private string _UrlView = "~/Views/Travels";
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
        public async Task<JsonResult> Get(Facturacion facturacion)
        {
            List<Facturacion> facturas;
            facturas = await _appContext.Execute<List<Facturacion>>(MethodType.GET,_UrlApi, facturacion);
            return Json(facturas);
        }

        [HttpPost]
        //[Route("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                //string ruta = _hostingEnvironment.ContentRootPath + @"\Uploads\";
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
                Facturacion result =  new Facturacion();
                if (isSaved)
                {
                    result = await _appContext.Execute<Facturacion>(MethodType.POST, _UrlApi, facturacion);
                }
                //return Json(result);
                return RedirectToAction("Get", new { facturacion = result});
                //return View();

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

        [HttpGet]
        [Route("downloadFile")]
        public ActionResult DownloadFile(string fileName, string fullpath)
        {
            //var ruta = Server.MapPath();
            //var fileExists = IoFile.Exists(fullpath);
            //var fs = IoFile.OpenRead(fullpath);            
            //return  PhysicalFile(fullpath, GetContentType(fileName),true);

            return File(fullpath, "text/plain", fileName);
            //return result;
            //return File(new FileStream(fullpath, FileMode.Open), GetContentType(fileName), fileName);

        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
        #endregion
    }
}
