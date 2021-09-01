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
using System.Threading.Tasks;

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
        public async Task<JsonResult> Get(Facturacion facturacion)
        {
            List<Facturacion> facturas;
            facturas = await _appContext.Execute<List<Facturacion>>(MethodType.GET, _UrlApi, facturacion);
            return Json(facturas);
        }

        [HttpPost]
        [Route("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file, int SectionId)
        {
            try
            {
                //string projectRootPath = _hostingEnvironment.ContentRootPath; ruta del poryecto
                string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"\Resources\Facturas\" + DateTime.Now.ToString("yyyy/MM/dd"));
                string res = Path.Combine(@"\Resources\Facturas\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MM") + "\\" + DateTime.Now.ToString("dd") + "\\" + file.FileName);

                string rutaFile = res.Replace("\\", "\\\\");

                string fullpath = Path.Combine(ruta, file.FileName);
                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);

                var isSaved = await SaveFile(file, fullpath);

                Facturacion facturacion = new Facturacion()
                {
                    SectionId = SectionId,
                    nombre = file.FileName,
                    fullpath = rutaFile,
                    fechacarga = DateTime.Now,
                    usuario = HttpContext.Session.GetString("UserFN")
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

        private async Task<bool> SaveFile(IFormFile file, string fullpath)
        {
            if (file is null)
                return false;

            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return true;
        }

        [HttpGet]
        [Route("downloadFile")]
        public FileResult DownloadFile(string fileName, string fullpath)
        {
            //string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"\Resources\Facturas\");
            //string fullpath = Path.Combine(ruta, fileName);
            //string fullpath = string.Format(@"~\Resources\Facturas\{0}", fileName);
            var result = File(fullpath, GetContentType(fileName), fileName);
            return result;
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
