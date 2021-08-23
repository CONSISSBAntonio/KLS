using Ionic.Zip;
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

        [Route("[action]/{id}")]
        public async Task<JsonResult> GetEquipos(string id)
        {
            Tr_Has_Inventario dataModel = new Tr_Has_Inventario();
            List<Tr_Has_Inventario> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Inventario>>(MethodType.GET, Path.Combine(_UrlApi, "GetEquipos", id), dataModel);
            var unidades = dataReport.GroupBy(
            p => p.TipoUnidad,
            p => p.TipoUnidadNombre,
            (key, g) => new { TipoUnidad = key, Nombre = g });
            return Json(new { unidades, dataReport });
        }



        [HttpPost]
        [Route("setInventory")]
        public async Task<JsonResult> Post(Tr_Has_Inventario jsonData, IFormFile file, IFormFile file1, int IdTransportista)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            string rutaHoy = @DateTime.Now.ToString("yyyy/MM/dd") + "\\" + IdTransportista + "\\" + rutaRandom;
            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + "\\Resources\\Inventario\\" + rutaHoy);

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
                jsonData.FotoUnidad = nombreUnidad;
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

            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + "\\Resources\\Inventario\\" + jsonData.Ruta);

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
                jsonData.FotoPoliza = nombrePoliza;
            }

            Tr_Has_Inventario dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Inventario>(MethodType.PUT, _UrlApi, jsonData);
            return Json(dataReport);
        }

        [Route("DescargarZip/{id}")]
        public async Task<FileResult> DescargarAsync(string id)
        {

            Random rdn = new Random();
            int nombreRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            using (ZipFile zip = new ZipFile())
            {
                Tr_Has_Inventario operador = new Tr_Has_Inventario();
                Tr_Has_Inventario data = await AppContext.Execute<Tr_Has_Inventario>(MethodType.GET, Path.Combine(_UrlApi, "getInventario", id), operador);

                var rutas = @_hostingEnvironment.WebRootPath + "\\Resources\\Inventario\\" + data.Ruta + "\\";

                //zip.AddDirectory(rutas);
                if (data.FotoPoliza != null)
                {
                    zip.AddFile(Path.Combine(rutas + data.FotoPoliza), "");
                }
                if (data.FotoUnidad != null)
                {
                    zip.AddFile(Path.Combine(rutas + data.FotoUnidad), "");
                }

                string nombreDescarga = data.Id + data.Placa;

                using (MemoryStream output = new MemoryStream())
                {
                    zip.Save(output);
                    return File(output.ToArray(), "application/zip", nombreDescarga.ToUpper() + ".zip");
                }
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
    }
}
