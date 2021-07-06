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

namespace KLS_WEB.Controllers.Carriers.CarriersOperators
{
    [Route("Carriers/Operators")]
    [Authorize]
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

        //[Route("setOperators")]
        //public async Task<JsonResult> Post(Tr_Has_Operadores dataModel)
        //{
        //    Tr_Has_Operadores dataReport;
        //    dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.POST, _UrlApi, dataModel);
        //    return Json(dataReport);
        //}

        [HttpPost]
        [Route("setOperators")]
        public async Task<JsonResult> Post(Tr_Has_Operadores jsonData, IFormFile file, IFormFile file1, int IdTransportista)
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

            string InePath = "";
            string LicenciaPath = "";

            if (file != null)
            {
                nombreIne = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                InePath = Path.Combine(ruta, nombreIne);
                await SaveFile(file, InePath);
                jsonData.FotoIne = nombreIne;
            }

            if (file1 != null)
            {
                nombreLicencia = string.Format("{0}{1:yyyyMMdd_HHmm_ss}.{2}", Path.GetFileNameWithoutExtension(file1.FileName), DateTime.Now, Path.GetExtension(file1.FileName));
                LicenciaPath = Path.Combine(ruta, nombreLicencia);
                await SaveFile(file1, LicenciaPath);
                jsonData.FotoLicencia = nombreLicencia;
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
        public async Task<JsonResult> Put(Tr_Has_Operadores dataModel)
        {
            Tr_Has_Operadores dataReport;
            dataReport = await this.AppContext.Execute<Tr_Has_Operadores>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
