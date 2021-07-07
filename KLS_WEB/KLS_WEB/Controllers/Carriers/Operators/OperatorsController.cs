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
using System.Text;

namespace KLS_WEB.Controllers.Carriers.CarriersOperators
{
    [Route("Carriers/Operators")]
    //[Authorize]
    public class OperatorsController : Controller
    {
        
        private string _UrlView = "~/Views/Carriers/Operators/";
        private string _UrlApi = "Carriers/Operators";

        private readonly IAppContextService AppContext;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public OperatorsController(IAppContextService _AppContext, IWebHostEnvironment hostingEnvironment)
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

        [Route("getOperators")]
        public async Task<JsonResult> Get(Tr_Has_Operadores dataModel)
        {
            List<Tr_Has_Operadores> dataReport;
            dataReport = await this.AppContext.Execute<List<Tr_Has_Operadores>>(MethodType.GET, _UrlApi, dataModel);
            return Json(dataReport);
        }
        
        [Route("[action]/{id}")]
        public async Task<JsonResult> GetOperator(string id)
        {
            Tr_Has_Operadores operador = new Tr_Has_Operadores();
            Tr_Has_Operadores data = await AppContext.Execute<Tr_Has_Operadores>(MethodType.GET, Path.Combine(_UrlApi, "GetOperator", id), operador);
            return Json(data);
        }


        [HttpPost]
        [Route("setOperators")]
        public async Task<JsonResult> Post(Tr_Has_Operadores jsonData, IFormFile file, IFormFile file1,IFormFile file2, int IdTransportista)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);

            string rutaHoy = @DateTime.Now.ToString("yyyy/MM/dd") + "/" + IdTransportista + "/" + rutaRandom;
            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Operadores/" + rutaHoy);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            string nombreIne = "";
            string nombreLicencia = "";
            string nombreSeguro = "";

            string InePath = "";
            string LicenciaPath = "";
            string SeguroPath = "";

            if (file != null)
            {
                nombreLicencia = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}",rdn.Next(10000, 10000000), DateTime.Now, Path.GetExtension(file.FileName));
                LicenciaPath = Path.Combine(ruta, nombreLicencia);
                await SaveFile(file, LicenciaPath);
                jsonData.FotoLicencia = nombreLicencia;
            }

            if (file1 != null)
            {
                nombreIne = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}",rdn.Next(10000, 100000), DateTime.Now, Path.GetExtension(file1.FileName));
                InePath = Path.Combine(ruta, nombreIne);
                await SaveFile(file1, InePath);
                jsonData.FotoIne = nombreIne;
            }
            
            if (file2 != null)
            {
                nombreSeguro = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}", rdn.Next(10000, 100000), DateTime.Now, Path.GetExtension(file2.FileName));
                SeguroPath = Path.Combine(ruta, nombreSeguro);
                await SaveFile(file2, SeguroPath);
                jsonData.FotoSeguro = nombreSeguro;
            }

            jsonData.Ruta = rutaHoy;
            jsonData.Id_Transportista = IdTransportista;

            Tr_Has_Operadores dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.POST, _UrlApi, jsonData);
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


        [Route("putOperators")]
        public async Task<JsonResult> Put(Tr_Has_Operadores jsonData, IFormFile file, IFormFile file1,IFormFile file2, int IdTransportista)
        {
            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);

            string nombreIne = "";
            string nombreLicencia = "";
            string nombreSeguro = "";

            string InePath = "";
            string LicenciaPath = "";
            string SeguroPath = "";

            string ruta = Path.Combine(_hostingEnvironment.WebRootPath + @"/Resources/Operadores/" + jsonData.Ruta);

            if (file != null)
            {
                nombreLicencia = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", rdn.Next(10000, 100000), DateTime.Now, Path.GetExtension(file.FileName));
                LicenciaPath = Path.Combine(ruta, nombreLicencia);
                await SaveFile(file, LicenciaPath);
                jsonData.FotoLicencia = nombreLicencia;
            }

            if (file1 != null)
            {
                nombreIne = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", rdn.Next(10000, 100000), DateTime.Now, Path.GetExtension(file1.FileName));
                InePath = Path.Combine(ruta, nombreIne);
                await SaveFile(file1, InePath);
                jsonData.FotoIne = nombreIne;
            }

            if (file2 != null)
            {
                nombreSeguro = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", rdn.Next(10000, 100000), DateTime.Now, Path.GetExtension(file2.FileName));
                SeguroPath = Path.Combine(ruta, nombreSeguro);
                await SaveFile(file2, SeguroPath);
                jsonData.FotoSeguro = nombreSeguro;
            }

            jsonData.Id_Transportista = IdTransportista;

            Tr_Has_Operadores dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.PUT, _UrlApi, jsonData);
            return Json(dataReport);
        }

        [Route("DescargarZip/{id}")]
        public async Task<FileResult> DescargarAsync(string id)
        {
            
            Random rdn = new Random();
            int nombreRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            using (ZipFile zip = new ZipFile())
            {
                Tr_Has_Operadores operador = new Tr_Has_Operadores();
                Tr_Has_Operadores data = await AppContext.Execute<Tr_Has_Operadores>(MethodType.GET, Path.Combine(_UrlApi, "GetOperator", id), operador);

                var rutas = @_hostingEnvironment.WebRootPath + "/Resources/Operadores/" + data.Ruta+"/";

                //zip.AddDirectory(rutas);
                if (data.FotoSeguro != null)
                {
                    zip.AddFile(Path.Combine(rutas + data.FotoSeguro), "");
                }
                if (data.FotoIne != null)
                {
                    zip.AddFile(Path.Combine(rutas + data.FotoIne), "");
                }
                if (data.FotoLicencia != null)
                {
                    zip.AddFile(Path.Combine(rutas + data.FotoLicencia), "");
                }

                using (MemoryStream output = new MemoryStream())
                {
                    zip.Save(output);
                    return File(output.ToArray(), "application/zip", nombreRandom + ".zip");
                }

            }


        }
        
    }
}
