using KLS_WEB.Models;
using KLS_WEB.Models.Clients;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Tracking;
using KLS_WEB.Models.Travels;
using KLS_WEB.Models.Travels.DTO;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Tracking
{
    public class TrackingController : Controller
    {
        private string _UrlView = "~/Views/Tracking/";
        private string _UrlApi = "Tracking";

        private readonly IAppContextService _appContext;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public TrackingController(IAppContextService appContext, IWebHostEnvironment webHostEnvironment)
        {
            _appContext = appContext;
            _hostingEnvironment = webHostEnvironment;
        }


        #region InitSelects
        private async Task<List<SelectListItem>> GetCustomers()
        {
            //List<SelectListItem> selectListItems = new List<SelectListItem> { new SelectListItem { Disabled = true, Value = "0", Text = "SELECCIONA" } };
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            List<Clientes> clientes = await _appContext.Execute<List<Clientes>>(MethodType.GET, Path.Combine(_UrlApi, "GetCustomers"), null);

            foreach (var cliente in clientes)
            {
                SelectListItem selectListItem = new SelectListItem { Value = cliente.id.ToString(), Text = cliente.NombreCorto.ToUpper() };
                selectListItems.Add(selectListItem);
            }

            return selectListItems;
        }
        private async Task<List<SelectListItem>> GetStatuses()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "NO HAY SELECCIÓN" } };
            List<Status> statuses = await _appContext.Execute<List<Status>>(MethodType.GET, Path.Combine(_UrlApi, "GetStatuses"), null);

            foreach (var status in statuses)
            {
                SelectListItem selectListItem = new SelectListItem { Value = status.Id.ToString(), Text = status.Name.ToUpper() };
                selectListItems.Add(selectListItem);
            }

            return selectListItems;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            Counter counter = await _appContext.Execute<Counter>(MethodType.GET, Path.Combine(_UrlApi, "TrackingCounter"), null);

            TrackingDTO tracking = new TrackingDTO
            {
                Todos = counter.Todos,
                Confirmados = counter.Confirmados,
                EnTransito = counter.EnTransito,
                Demorados = counter.Demorados,
                Selects = new TrackingDTO.InitSelects
                {
                    Customers = await GetCustomers(),
                    Statuses = await GetStatuses()
                }
            };

            return View(tracking);
        }

        [HttpGet]
        public async Task<JsonResult> GetSubstatuses(string StatusId)
        {
            ICollection<Substatus> substatuses = await _appContext.Execute<List<Substatus>>(MethodType.GET, Path.Combine(_UrlApi, "GetSubstatuses", StatusId), null);
            return Json(substatuses);
        }

        #region Comment&Status
        [HttpPost]
        public async Task<JsonResult> AddSectionComment([FromForm] AddSectionComment addSectionComment)
        {
            bool grupoMonitor = string.IsNullOrEmpty(addSectionComment.GrupoMonitor?.Trim());
            SectionCommentDTO newSectionComment = new SectionCommentDTO
            {
                SectionId = addSectionComment.SectionId,
                SubstatusId = addSectionComment.SubstatusId,
                Comment = addSectionComment.Comment,
                GrupoMonitor = grupoMonitor ? null : addSectionComment.GrupoMonitor.Trim(),
                CreatedBy = HttpContext.Session.GetString("UserFN")
            };

            SectionComment sectionComment = await _appContext.Execute<SectionComment>(MethodType.POST, Path.Combine(_UrlApi, "AddSectionComment"), newSectionComment);

            if (addSectionComment.File != null && sectionComment != null)
            {
                string path = @DateTime.Now.ToString("yyyy/MM/dd") + "/" + sectionComment.Id + "/";
                string ruta = @Path.Combine(_hostingEnvironment.WebRootPath + "/Resources/Monitoring/" + path);

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                foreach (var file in addSectionComment.File)
                {
                    Evidence evidence = new Evidence
                    {
                        SectionCommentId = sectionComment.Id,
                        Name = file.FileName,
                        Path = path,
                        CreatedBy = HttpContext.Session.GetString("UserFN")
                    };

                    Evidence newEvidence = await _appContext.Execute<Evidence>(MethodType.POST, Path.Combine(_UrlApi, "AddEvidence"), evidence);
                    if (newEvidence != null)
                    {
                        string nombreArchivo = string.Format("{0}{1:yyyyMMdd_HHmm_ss}{2}", Path.GetFileNameWithoutExtension(file.FileName), DateTime.Now, Path.GetExtension(file.FileName));
                        string archivoPath = @Path.Combine(ruta, nombreArchivo);
                        await SaveFile(file, archivoPath);
                    }
                }
            }
            return Json(sectionComment);
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

        #region Events
        [HttpGet]
        public async Task<JsonResult> GetDetails(string SectionId)
        {
            Section section = await _appContext.Execute<Section>(MethodType.GET, Path.Combine(_UrlApi, "GetDetails", SectionId), null);
            return Json(section);
        }
        #endregion
        #region DataTable
        [HttpPost]
        public async Task<JsonResult> DataTable(DataTablesParameters dtParams)
        {
            TrackingDTModel data = await _appContext.Execute<TrackingDTModel>(MethodType.POST, Path.Combine(_UrlApi, "DataTable"), dtParams);
            return Json(data);
        }
        #endregion
    }
}
