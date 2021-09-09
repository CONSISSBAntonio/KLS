using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Models.Monitoring;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Monitoring
{
    [Route("Monitoring")]
    [Authorize]
    public class MonitoringController : Controller
    {
        private string _UrlView = "~/Views/Monitoring/";
        private string _UrlApi = "Monitoring";

        private readonly IAppContextService AppContext;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public MonitoringController(IAppContextService _AppContext, IWebHostEnvironment hostingEnvironment)
        {
            this.AppContext = _AppContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getMonitoring")]
        public async Task<JsonResult> Get(Monitoring mon)
        {
            List<Monitoring> dataMonitoring;
            dataMonitoring = await this.AppContext.Execute<List<Monitoring>>(MethodType.GET, _UrlApi, mon);
            return Json(dataMonitoring);
        }

        public class Monitoring
        {
            public string folio { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public string fechallegada { get; set; }
            public string fechallegada_ { get; set; }
            public string estatus { get; set; }
            public int estatusId { get; set; } //Estatud
            public string substatus { get; set; }
            public int subestatusId { get; set; }
            public int idviaje { get; set; }
            public string cliente { get; set; }
            public string fechasalida { get; set; }
            public int tiemporuta { get; set; }
            public int idcliente { get; set; }
            public int idruta { get; set; }
            public int frecuenciaValidacion { get; set; }
        }

        [Route("getClient")]
        public async Task<JsonResult> getClient()
        {
            List<Clientes> dataClient;
            dataClient = await this.AppContext.Execute<List<Clientes>>(MethodType.GET, _UrlApi + "/getClient", null);
            return Json(dataClient);
        }

        [Route("getStatus")]
        public async Task<JsonResult> getStatus()
        {
            List<Status> dataClient;
            dataClient = await this.AppContext.Execute<List<Status>>(MethodType.GET, _UrlApi + "/getStatus", null);
            return Json(dataClient);
        }

        [Route("getSubStatus")]
        public async Task<JsonResult> getSubStatus()
        {
            List<Substatus> dataClient;
            dataClient = await this.AppContext.Execute<List<Substatus>>(MethodType.GET, _UrlApi + "/getSubStatus", null);
            return Json(dataClient);
        }

        [HttpPost]
        [Route("setCommentario")]
        public async Task<JsonResult> setCommentario(SectionComment jsonData, IFormFile file)
        {

            Random rdn = new Random();
            int rutaRandom = rdn.Next(10000, 100000) + rdn.Next(10000, 100000);
            string rutaHoy = @DateTime.Now.ToString("yyyy/MM/dd") + "/" + jsonData.SectionId + "/" + rutaRandom;
            string ruta = @Path.Combine(this._hostingEnvironment.WebRootPath + "/Resources/Monitoring/" + rutaHoy);

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            string nombreArchivo = "";
            string archivoPath = "";

            if (file != null)
            {
                nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                archivoPath = @Path.Combine(ruta, nombreArchivo);
                await SaveFile(file, archivoPath);
            }

            var evidences = new Evidence();
            evidences.Name = nombreArchivo;
            evidences.Path = rutaHoy;
            evidences.Active = true;
            evidences.CreatedBy = HttpContext.Session.GetString("Nombre") + " " + HttpContext.Session.GetString("Apaterno") + " " + HttpContext.Session.GetString("Amaterno"); ;

            List<Evidence> icollection = new List<Evidence>();
            icollection.Add(evidences);

            //jsonData./*StatusId*/ = 1;
            jsonData.Evidences = icollection;
            jsonData.Active = true;
            jsonData.CreatedBy = HttpContext.Session.GetString("Nombre") + " " + HttpContext.Session.GetString("Apaterno") + " " + HttpContext.Session.GetString("Amaterno"); ;
            /*
             * {
                    "SectionId":22,
                    "SubstatusId":1,
                    "Comment":"Prueba de in",
                    "Evidence":
                        [
                            {
                            "Name":"Nombre",
                            "Path":"ruta/",
                            "Active":true,
                            "CreatedBy":"Braulio Antonio"
                            }
                        ]
                    ,
                    "Active":true,
                    "CreatedBy":"Braulio Prueba",
                    "UpdatedBy":"asd"
                }
             */


            //jsonData.Ruta = Path.Combine(rutaHoy, "");
            //jsonData.Id_Transportista = IdTransportista;
            //var culture = new CultureInfo("en-US");

            //DateTime localDate = DateTime.Now;
            //jsonData.FechaEvento = localDate;

            SectionComment asd = new SectionComment();
            asd = await this.AppContext.Execute<SectionComment>(MethodType.POST, _UrlApi + "/setCommentario", jsonData);
            if (jsonData.SubstatusId == 5)
            {
                await AppContext.Execute<Section>(MethodType.POST, Path.Combine("Travels", "CreateOffer", jsonData.SectionId.ToString()), null);
            }
            return Json(asd);
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

        //Obtener checkpoints
        [Route("getCheckpoints/{id}")]
        public async Task<JsonResult> getCheckpoints(int id)
        {
            List<Ruta_Has_Checkpoint> dataCheck;
            dataCheck = await this.AppContext.Execute<List<Ruta_Has_Checkpoint>>(MethodType.GET, _UrlApi + "/getCheckpoints/" + id, null);
            return Json(dataCheck);
        }

        [Route("getSCheckpoints/{id}")]//Id seccion
        public async Task<JsonResult> getSCheckpoints(int id)
        {
            List<Section_Has_Checkpoint> dataCheck;
            dataCheck = await this.AppContext.Execute<List<Section_Has_Checkpoint>>(MethodType.GET, _UrlApi + "/getSCheckpoints/" + id, null);
            return Json(dataCheck);
        }

        [HttpPost]
        [Route("setSCheckpoints")]
        public async Task<JsonResult> setSCheckpoints(Section_Has_Checkpoint dataModel)
        {
            dataModel.CreatedBy = HttpContext.Session.GetString("Nombre") + " " + HttpContext.Session.GetString("Apaterno") + " " + HttpContext.Session.GetString("Amaterno");
            Section_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Section_Has_Checkpoint>(MethodType.POST, _UrlApi + "/setSCheckpoints", dataModel);
            return Json(dataReport);
        }

    }
}
