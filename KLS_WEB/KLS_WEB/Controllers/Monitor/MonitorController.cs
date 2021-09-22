using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Models.Clients.DTO;
using KLS_WEB.Models.Monitoring;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KLS_WEB.Controllers.Monitor
{
    [Authorize]
    public class MonitorController : Controller
    {
        private string _UrlView = "~/Views/Monitor/";
        private string _UrlApi = "Monitoring";

        private readonly IAppContextService AppContext;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MonitorController(IAppContextService _AppContext, IWebHostEnvironment hostingEnvironment)
        {
            this.AppContext = _AppContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> IndexAsync()
        {
            ClientsDTO clientsDTO = new ClientsDTO();
            clientsDTO.Selects.Clientes = await GetClients();
            clientsDTO.Selects.Status = await GetStatus();
            clientsDTO.Selects.SubStatus = await GetSubStatus();
            return View(clientsDTO);
        }

        #region InitSelects
        private async Task<List<SelectListItem>> GetClients() {
            List<SelectListItem> Clients_ = new List<SelectListItem> { new SelectListItem { Disabled = false, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Clientes> clientes = await AppContext.Execute<List<Clientes>>(MethodType.GET, Path.Combine(_UrlApi, "getClient"), null);
            foreach (var client in clientes)
            {
                SelectListItem selectListItem = new SelectListItem { Value = client.id.ToString(), Text = client.NombreComercial };
                Clients_.Add(selectListItem);
            }
            return Clients_;
        }

        private async Task<List<SelectListItem>> GetStatus()
        {
            List<SelectListItem> status_ = new List<SelectListItem> { new SelectListItem { Disabled = false, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Status> status = await AppContext.Execute<List<Status>>(MethodType.GET, Path.Combine(_UrlApi, "getStatus"), null);
            foreach (var itemStatus in status)
            {
                SelectListItem selectListItem = new SelectListItem { Value = itemStatus.Id.ToString(), Text = itemStatus.Name };
                status_.Add(selectListItem);
            }
            return status_;
        }

        private async Task<List<SelectListItem>> GetSubStatus()
        {
            List<SelectListItem> subStatus_ = new List<SelectListItem> { new SelectListItem { Disabled = false, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Substatus> subSstatus = await AppContext.Execute<List<Substatus>>(MethodType.GET, Path.Combine(_UrlApi, "getSubStatus"), null);
            foreach (var itemStatus in subSstatus)
            {
                SelectListItem selectListItem = new SelectListItem { Value = itemStatus.Id.ToString(), Text = itemStatus.Name };
                subStatus_.Add(selectListItem);
            }
            return subStatus_;
        }
        #endregion

        #region DatatableMonitoreo
        [HttpPost]
        public async Task<JsonResult> DataTableMonitoring(DTParams dtParams)
        {
            MonitoringDTModel data = await this.AppContext.Execute<MonitoringDTModel>(MethodType.POST, Path.Combine(_UrlApi, "DataTableMonitoring"), dtParams);
            return Json(data);
        }

        public class MonitoringDTModel {
            public List<Monitor_> aaData { get; set; }
            public int Draw { get; set; }
            public int ITotalRecords { get; set; }
            public int ITotalDisplayRecords { get; set; }
        }
        #endregion

        #region Comentarios
        public async Task<IActionResult> Comment(string id) {
            ClientsDTO clientsDTO = new ClientsDTO();
            clientsDTO.Selects.Status = await GetStatus();
            //clientsDTO.Selects.SubStatus = await GetSubStatus();
            clientsDTO.Selects.monitoreo = await this.AppContext.Execute<Monitor_>(MethodType.GET, Path.Combine(_UrlApi, "Comment?id=" + id), null);

            clientsDTO.Selects.Status[clientsDTO.Selects.monitoreo.estatusId].Selected = true;
            //clientsDTO.Selects.SubStatus[clientsDTO.Selects.monitoreo.subestatusId].Selected = true;
            return PartialView(_UrlView + "_AddComment.cshtml", clientsDTO);
        }

        [HttpPost]
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
            if (nombreArchivo != "") {
                jsonData.Evidences = icollection;
            }

            if (jsonData.Comment == "" || jsonData.Comment == null)
            {
                jsonData.Comment = "-";
            }

            jsonData.Active = true;
            jsonData.CreatedBy = HttpContext.Session.GetString("Nombre") + " " + HttpContext.Session.GetString("Apaterno") + " " + HttpContext.Session.GetString("Amaterno"); ;

            SectionComment asd = new SectionComment();
            asd = await this.AppContext.Execute<SectionComment>(MethodType.POST, Path.Combine(_UrlApi, "SetCommentario"), jsonData);

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
        #endregion

        #region InfoMonitor
        public async Task<IActionResult> getInfo(int id)
        {
            InfoMonitor infomonitor;
            infomonitor = await this.AppContext.Execute<InfoMonitor>(MethodType.GET, Path.Combine(_UrlApi, "getInfo?id=" + id), null);
            return PartialView(_UrlView + "_InfoMonitor.cshtml", infomonitor);
        }
        #endregion

        #region Checkpoints
        public async Task<IActionResult> Checkpoint(int idviaje, int idruta, string fecha) {
            Checkpoints checkpoints;
            checkpoints = await this.AppContext.Execute<Checkpoints>(MethodType.GET, Path.Combine(_UrlApi, "Checkpoint?idviaje=" + idviaje + "&idruta=" + idruta), null);
            checkpoints.fechasalida = fecha.ToString();
            checkpoints.idviaje = idviaje;
            checkpoints.idruta = idruta;
            return PartialView(_UrlView + "_Checkpoints.cshtml", checkpoints);
        }

        [HttpPost]
        public async Task<JsonResult> setSCheckpoints(Section_Has_Checkpoint dataModel)
        {
            dataModel.CreatedBy = HttpContext.Session.GetString("Nombre") + " " + HttpContext.Session.GetString("Apaterno") + " " + HttpContext.Session.GetString("Amaterno");
            Section_Has_Checkpoint dataReport;
            dataReport = await this.AppContext.Execute<Section_Has_Checkpoint>(MethodType.POST, Path.Combine(_UrlApi, "setSCheckpoints"), dataModel);
            return Json(dataReport);
        }

        public async Task<JsonResult> getSubStatusFind(int id = 0)
        {
            List<Substatus> dataReport;
            dataReport = await this.AppContext.Execute<List<Substatus>>(MethodType.POST, Path.Combine(_UrlApi, "getSubStatus?id=" + id), null);
            return Json(dataReport);
        }

        #endregion

        public async Task<JsonResult> getConteo() {
            List<Conteo> dataReport;
            dataReport = await this.AppContext.Execute<List<Conteo>>(MethodType.GET, Path.Combine(_UrlApi, "getConteo"), null);
            return Json(dataReport);
        }

        public class Conteo{
            public int key { set;get;}
            public int count { set;get;}
        }

        public async Task<JsonResult> downloadExcel()
        {
            List<Monitor_> dataReport;
            dataReport = await this.AppContext.Execute<List<Monitor_>>(MethodType.GET, Path.Combine(_UrlApi, "downloadExcel"), null);
            return Json(dataReport);
        }

    }
}

//21090007-01