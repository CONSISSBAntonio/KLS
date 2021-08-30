using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Clients
{
    [Route("Clients/Library")]
    [Authorize]
    public class LibraryController : Controller
    {
        private string _UrlView = "~/Views/Clients/Library/";
        private string _UrlApi = "Clients/Library";

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

        //--------------------------------------------
        [Route("getLibrary")]
        public async Task<JsonResult> Get(Cl_Has_Biblioteca dataModel)
        {
            List<Cl_Has_Biblioteca> dataReport;
            dataReport = await this.AppContext.Execute<List<Cl_Has_Biblioteca>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setLibrary")]
        public async Task<JsonResult> Post(Cl_Has_Biblioteca jsonData, IFormFile file, int Id_Cliente)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            string rutaHoy = @DateTime.Now.ToString("yyyy/MM/dd") + "/" + Id_Cliente + "/" + rutaRandom;
            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Clientes/Biblioteca/" + rutaHoy);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string nombreArchivo = "";
            string archivoPath = "";

            if (file != null)
            {
                nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                archivoPath = Path.Combine(ruta, nombreArchivo);
                await SaveFile(file, archivoPath);
                jsonData.Archivo = nombreArchivo;
            }

            jsonData.Ruta = rutaHoy;
            jsonData.Id_Cliente = Id_Cliente;
            var culture = new CultureInfo("en-US");

            DateTime localDate = DateTime.Now;
            jsonData.FechaEvento = localDate;

            Cl_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Biblioteca>(MethodType.POST, _UrlApi, jsonData);
            return Json(dataReport);
        }

        [Route("putLibrary")]
        public async Task<JsonResult> Put(Cl_Has_Biblioteca jsonData, IFormFile file, int Id_Cliente)
        {
            string nombreArchivo = "";
            string archivoPath = "";

            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Clientes/Biblioteca/" + jsonData.Ruta);

            if (file != null)
            {
                nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                archivoPath = Path.Combine(ruta, nombreArchivo);
                await SaveFile(file, archivoPath);
                jsonData.Archivo = nombreArchivo;
            }

            jsonData.Id_Cliente = Id_Cliente;

            DateTime localDate = DateTime.Now;
            jsonData.FechaEvento = localDate;

            Cl_Has_Biblioteca dataReport;
            dataReport = await this.AppContext.Execute<Cl_Has_Biblioteca>(MethodType.PUT, _UrlApi, jsonData);
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
