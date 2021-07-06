using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
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

namespace KLS_WEB.Controllers.Carriers.CarriersInventory
{
    [Route("Carriers/Inventory")]
    [Authorize]
    public class InventoryController : Controller
    {
        private string _UrlView = "~/Views/Carriers/Inventory/";
        private string _UrlApi = "Carriers/Inventory";

        private readonly IAppContextService AppContext;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public InventoryController(IAppContextService _AppContext, IWebHostEnvironment hostingEnvironment)
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

        [Route("getInventory")]
        public async Task<JsonResult> Get(Tr_Has_Inventario dataModel)
        {
            List<Tr_Has_Inventario> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Inventario>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }

        //[Route("setInventory")]
        //public async Task<JsonResult> Post(Tr_Has_Inventario dataModel)
        //{
        //    Tr_Has_Inventario dataReport;
        //    dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.POST, _UrlApi, dataModel);
        //    return Json(dataReport);
        //}

        [HttpPost]
        [Route("setInventory")]
        public async Task<JsonResult> Post(Tr_Has_Inventario jsonData, IFormFile file, IFormFile file1, int IdTransportista)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            string rutaHoy = @DateTime.Now.ToString("yyyy/MM/dd")+"/"+ IdTransportista+"/"+ rutaRandom;
            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Inventario/" + rutaHoy);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            string nombreUnidad = "";
            string nombrePoliza = "";

            string unidadPath = "";
            string polizaPath = "";

            if (file != null)
            {
                nombreUnidad = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                unidadPath = Path.Combine(ruta, nombreUnidad);
                await SaveFile(file, unidadPath);
                jsonData.FotoPoliza = nombreUnidad;
            }

            if (file1 != null)
            {
                nombrePoliza = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file1.FileName), DateTime.Now, Path.GetExtension(file1.FileName));
                polizaPath = Path.Combine(ruta, nombrePoliza);
                await SaveFile(file1, polizaPath);
                jsonData.FotoPoliza = nombrePoliza;
            }

            jsonData.Ruta = rutaHoy;

            Tr_Has_Inventario dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.POST, _UrlApi, jsonData);
            return Json(dataReport);
        }

        [Route("putInventory")]
        public async Task<JsonResult> Put(Tr_Has_Inventario jsonData, IFormFile file, IFormFile file1, int IdTransportista)
        {
            string nombreUnidad = "";
            string nombrePoliza = "";

            string unidadPath = "";
            string polizaPath = "";

            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Inventario/" + jsonData.Ruta);

            if (file != null)
            {
                nombreUnidad = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", "", DateTime.Now, Path.GetExtension(file.FileName));
                unidadPath = Path.Combine(ruta, nombreUnidad);
                await SaveFile(file, unidadPath);
                jsonData.FotoUnidad = nombreUnidad;
            }

            if (file1 != null)
            {
                nombrePoliza = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", "", DateTime.Now, Path.GetExtension(file1.FileName));
                polizaPath = Path.Combine(ruta, nombrePoliza);
                await SaveFile(file1, polizaPath);
                jsonData.FotoUnidad = nombrePoliza;
            }

            Tr_Has_Inventario dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.PUT, _UrlApi, jsonData);
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
