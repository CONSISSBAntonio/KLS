using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Carriers.CarriersLibrary
{
    [Route("Carriers/Library")]
    [Authorize]
    public class LibraryController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Library/";
        private string _UrlApi = "Carriers/Library";

        private readonly IAppContextService AppContext;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public LibraryController(IAppContextService _AppContext, IWebHostEnvironment hostingEnvironment)
        {
            this.AppContext = _AppContext;
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("{id=0}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getLibrary")]
        public async Task<JsonResult> Get(Tr_Has_Biblioteca dataModel)
        {
            List<Tr_Has_Biblioteca> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Biblioteca>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setLibrary")]
        public async Task<JsonResult> Post(Tr_Has_Biblioteca jsonData, IFormFile file, int IdTransportista)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            string rutaHoy = DateTime.Now.ToString("yyyy/MM/dd") + "/" + IdTransportista + "/" + rutaRandom;
            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + "/Resources/Biblioteca/" + rutaHoy);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string nombreArchivo = "";
            string archivoPath = "";

            if (file != null)
            {
                nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                archivoPath = Path.Combine(ruta, nombreArchivo);
                await SaveFile(file, archivoPath);
                jsonData.Archivo = nombreArchivo;
            }

            jsonData.Ruta = Path.Combine(rutaHoy,"");
            jsonData.Id_Transportista = IdTransportista;
            var culture = new CultureInfo("en-US");


            DateTime localDate = DateTime.Now;
            jsonData.FechaEvento = localDate;

            Tr_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Biblioteca>(MethodType.POST, _UrlApi, jsonData);
            return Json(dataReport);
        }

        [Route("putLibrary")]
        public async Task<JsonResult> Put(Tr_Has_Biblioteca jsonData, IFormFile file, int IdTransportista)
        {
            string nombreArchivo = "";
            string archivoPath = "";

            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + "\\Resources\\Biblioteca\\" + jsonData.Ruta);
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            if (file != null)
            {
                nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                archivoPath = Path.Combine(ruta, nombreArchivo);
                await SaveFile(file, archivoPath);
                jsonData.Archivo = nombreArchivo;
            }

            jsonData.Id_Transportista = IdTransportista;
            
            DateTime localDate = DateTime.Now;
            jsonData.FechaEvento = localDate;

            Tr_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Biblioteca>(MethodType.PUT, _UrlApi, jsonData);
            return Json(dataReport);
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

        
    }
}
