﻿using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Models.Clients;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Travels;
using KLS_WEB.Models.Travels.DTO;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Travels
{
    [Authorize]
    public class TravelsController : Controller
    {
        private string _UrlView = "~/Views/Travels/";
        private string _UrlApi = "Travels";

        private readonly IAppContextService AppContext;

        public TravelsController(IAppContextService _AppContext)
        {
            AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region InitSelects
        private async Task<List<SelectListItem>> GetTiposUnidades()
        {
            List<SelectListItem> Cat_Tipos_Unidades = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Cat_Tipos_Unidades> cat_Tipos_Unidades = await AppContext.Execute<List<Cat_Tipos_Unidades>>(MethodType.GET, Path.Combine(_UrlApi, "GetTiposUnidades"), null);

            foreach (var tipounidad in cat_Tipos_Unidades)
            {
                SelectListItem selectListItem = new SelectListItem { Value = tipounidad.id.ToString(), Text = tipounidad.nombre };
                Cat_Tipos_Unidades.Add(selectListItem);
            }

            return Cat_Tipos_Unidades;
        }
        private async Task<List<SelectListItem>> GetTravelServices()
        {
            List<SelectListItem> listItems = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<TravelService> travelServices = await AppContext.Execute<List<TravelService>>(MethodType.GET, Path.Combine(_UrlApi, "GetTravelServices"), null);

            foreach (var travelService in travelServices)
            {
                SelectListItem selectListItem = new SelectListItem { Value = travelService.Id.ToString(), Text = travelService.Name };
                listItems.Add(selectListItem);
            }

            return listItems;
        }
        private async Task<List<SelectListItem>> GetCustomers()
        {
            List<SelectListItem> Customers = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Clientes> customers = await AppContext.Execute<List<Clientes>>(MethodType.GET, Path.Combine(_UrlApi, "GetCustomers"), null);

            foreach (var customer in customers)
            {
                SelectListItem selectListItem = new SelectListItem { Value = customer.id.ToString(), Text = customer.NombreCorto };
                Customers.Add(selectListItem);
            }

            return Customers;
        }
        private async Task<List<SelectListItem>> GetRoute(int OriginId, int DestinationId)
        {
            SearchRuta searchRuta = new SearchRuta
            {
                OriginId = OriginId,
                DestinationId = DestinationId
            };

            List<SelectListItem> selectListItems = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<SearchRuta> routes = await AppContext.Execute<List<SearchRuta>>(MethodType.POST, Path.Combine(_UrlApi, "GetRoute"), searchRuta);

            foreach (var route in routes)
            {
                SelectListItem selectListItem = new SelectListItem { Value = route.Id.ToString(), Text = route.OD };
                selectListItems.Add(selectListItem);
            }

            return selectListItems;
        }
        private async Task<List<SelectListItem>> GetSectionType()
        {
            List<SelectListItem> listItems = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<SectionType> sectionTypes = await AppContext.Execute<List<SectionType>>(MethodType.GET, Path.Combine(_UrlApi, "GetSectionType"), null);

            foreach (var sectionType in sectionTypes)
            {
                SelectListItem listItem = new SelectListItem { Value = sectionType.Id.ToString(), Text = sectionType.Name };
                listItems.Add(listItem);
            }

            return listItems;
        }
        private async Task<TravelDTO> GetCustomerOD(int CustomerId)
        {
            TravelDTO travelDTO = new TravelDTO
            {
                Selects =
                {
                    CustomerOrigins = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } },
                    CustomerDestinations = new List<SelectListItem> { new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" } }
                }
            };

            CustomerOD customerOD = await AppContext.Execute<CustomerOD>(MethodType.GET, Path.Combine(_UrlApi, "GetCustomerOD", CustomerId.ToString()), null);

            foreach (var origin in customerOD.Origins)
            {
                SelectListItem selectListItem = new SelectListItem { Value = origin.Id.ToString(), Text = origin.Nombre };
                travelDTO.Selects.CustomerOrigins.Add(selectListItem);
            }
            foreach (var destination in customerOD.Destinations)
            {
                SelectListItem selectListItem = new SelectListItem { Value = destination.Id.ToString(), Text = destination.Nombre };
                travelDTO.Selects.CustomerDestinations.Add(selectListItem);
            }

            return travelDTO;
        }
        private async Task<List<SelectListItem>> GetCarriers()
        {
            List<SelectListItem> listItems = new List<SelectListItem> { new SelectListItem { Selected = true, Value = "0", Text = "SELECCIONA" } };
            List<Transportista> carriers = await AppContext.Execute<List<Transportista>>(MethodType.GET, Path.Combine(_UrlApi, "GetCarriers"), null);

            foreach (var carrier in carriers)
            {
                SelectListItem listItem = new SelectListItem { Value = carrier.id.ToString(), Text = carrier.NombreComercial };
                listItems.Add(listItem);
            }

            return listItems;
        }
        #endregion

        #region Travel
        [Route("[controller]/[action]/{TravelId}")]
        public async Task<IActionResult> AddEdit(int TravelId)
        {
            TravelDTO travelDTO = new TravelDTO
            {
                Selects =
                {
                    TravelServices = await GetTravelServices(),
                    Customers = await GetCustomers(),
                    SectionType = await GetSectionType()
                }
            };

            if (TravelId > 0)
            {
                travelDTO.Travel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine(_UrlApi, "GetTravel", TravelId.ToString()), null);
                TempData["TravelId"] = TravelId;
                TempData.Keep();
            }

            return View(travelDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddEditTravel(TravelDTO model)
        {
            var UserName = HttpContext.Session.GetString("UserFN");

            if (model.Travel.Id == 0)
            {
                model.Travel.CreatedBy = UserName;
            }
            else
            {
                model.Travel.UpdatedBy = UserName;
            }

            // SETSELECTS
            model.Selects.TravelServices = await GetTravelServices();
            model.Selects.Customers = await GetCustomers();
            model.Selects.SectionType = await GetSectionType();

            // SET TRAVEL
            MethodType method = model.Travel.Id > 0 ? MethodType.PUT : MethodType.POST;
            string action = model.Travel.Id > 0 ? "PutTravel" : "PostTravel";

            var ok = await AppContext.Execute<int>(method, Path.Combine(_UrlApi, action), model.Travel);

            return RedirectToAction("AddEdit", new { TravelId = ok });
        }
        #endregion

        #region Section
        [HttpGet]
        public async Task<JsonResult> GetCustomerOD(string CustomerId)
        {
            CustomerOD customerOD = await AppContext.Execute<CustomerOD>(MethodType.GET, Path.Combine(_UrlApi, "GetCustomerOD", CustomerId), null);
            return Json(customerOD);
        }

        [HttpGet]
        public async Task<IActionResult> GetSection(int SectionId)
        {
            TravelDTO travelDTO = new TravelDTO();
            if (SectionId > 0)
            {
                travelDTO.Section = await AppContext.Execute<Section>(MethodType.GET, Path.Combine(_UrlApi, "GetSection", SectionId.ToString()), null);
            }

            // INIT SELECTS
            travelDTO.Selects.Cat_Tipos_Unidades = await GetTiposUnidades();
            travelDTO.Selects.Customers = await GetCustomers();
            travelDTO.Selects.SectionType = await GetSectionType();
            var customerOD = await GetCustomerOD(travelDTO.Section.ClientesId);
            travelDTO.Selects.CustomerOrigins = customerOD.Selects.CustomerOrigins;
            travelDTO.Selects.CustomerDestinations = customerOD.Selects.CustomerDestinations;
            if (travelDTO.Section.Cl_Has_OrigenId != 0 && travelDTO.Section.Cl_Has_DestinosId != 0)
            {
                travelDTO.Selects.Routes = await GetRoute(travelDTO.Section.Cl_Has_OrigenId, travelDTO.Section.Cl_Has_DestinosId);
            }
            if (SectionId > 0)
            {
                travelDTO.Selects.Carriers = await GetCarriers();
            }
            // END INIT SELECTS

            TempData["SectionId"] = SectionId;
            TempData.Keep();

            return PartialView(string.Concat(_UrlView, "_Section.cshtml"), travelDTO);
        }
        [HttpGet]
        public async Task<JsonResult> GetSectionServices(int SectionId)
        {
            Section section = new Section();
            if (SectionId > 0)
            {
                section = await AppContext.Execute<Section>(MethodType.GET, Path.Combine(_UrlApi, "GetSection", SectionId.ToString()), null);
            }
            return Json(section);
        }

        [HttpPost]
        public async Task<JsonResult> AddEditSection(TravelDTO travelDTO)
        {
            var UserName = HttpContext.Session.GetString("UserFN");
            travelDTO.Section.TravelId = (int)TempData["TravelId"];
            TempData.Keep();

            if (travelDTO.Section.Id == 0)
            {
                travelDTO.Travel.CreatedBy = UserName;
            }
            else
            {
                travelDTO.Travel.UpdatedBy = UserName;
            }

            MethodType sectionMethod = travelDTO.Section.Id > 0 ? MethodType.PUT : MethodType.POST;
            string sectionAction = travelDTO.Section.Id > 0 ? "PutSection" : "PostSection";

            int SectionId = await AppContext.Execute<int>(sectionMethod, Path.Combine(_UrlApi, sectionAction), travelDTO.Section);
            TempData["SectionId"] = SectionId;
            TempData.Keep();

            return Json(SectionId);
        }

        [HttpGet]
        public async Task<JsonResult> DeleteSection(string SectionId)
        {
            Section section = await AppContext.Execute<Section>(MethodType.DELETE, Path.Combine(_UrlApi, "DeleteSection", SectionId), null);
            return Json(section);
        }

        [HttpGet]
        public async Task<JsonResult> GetClientReferences(string ClientId)
        {
            Cl_Has_Otros cl_Has_Otros = await AppContext.Execute<Cl_Has_Otros>(MethodType.GET, Path.Combine(_UrlApi, "GetClientReferences", ClientId), null);
            return Json(cl_Has_Otros);
        }
        #endregion

        #region Services
        [HttpPost]
        public async Task<IActionResult> GetServices([FromBody] ServicesDTO servicesDTOs)
        {
            servicesDTOs.Selects.Carriers = await GetCarriers();
            return PartialView(string.Concat(_UrlView, "_Service.cshtml"), servicesDTOs);
        }

        public class ServicesModel
        {
            public string ServiceId { get; set; }
            public int SectionId { get; set; }
            public string Service { get; set; }
            public string Cost { get; set; }
            public string Price { get; set; }
            public string CarrierId { get; set; }
            public string DriverId { get; set; }
            public List<Unidad> Units { get; set; }
            public class Unidad
            {
                public string Id { get; set; }
                public string TypeId { get; set; }
                public string UnitId { get; set; }
            }
        }

        [HttpPost]
        public async Task<JsonResult> AddServices([FromBody] ServicesModel model)
        {
            model.SectionId = (int)TempData["SectionId"];
            TempData.Keep();
            await AppContext.Execute<ServicesModel>(MethodType.POST, Path.Combine(_UrlApi, "AddEditServices"), model);

            return Json(model);
        }

        [HttpGet]
        public async Task<JsonResult> DeleteService(string ServiceId)
        {
            ServicesDTO service = await AppContext.Execute<ServicesDTO>(MethodType.DELETE, Path.Combine(_UrlApi, "DeleteService", ServiceId), null);
            //SetHistorial(string.Concat(service.Nombre, ", servicio eliminado"));
            return Json(ServiceId);
        }

        [HttpGet]
        public async Task<JsonResult> DeleteUnit(string UnitId)
        {
            Unit unit = await AppContext.Execute<Unit>(MethodType.DELETE, Path.Combine(_UrlApi, "DeleteUnit", UnitId), null);
            return Json(unit);
        }
        #endregion

        public class SearchRuta
        {
            public int Id { get; set; }
            public string OD { get; set; }
            public int OriginId { get; set; }
            public int DestinationId { get; set; }
        }

        [HttpPost]
        public async Task<JsonResult> GetRoute([FromBody] SearchRuta search)
        {
            List<SearchRuta> route = await AppContext.Execute<List<SearchRuta>>(MethodType.POST, Path.Combine(_UrlApi, "GetRoute"), search);
            return Json(route);
        }

        [HttpGet]
        public async Task<JsonResult> GetAddress(string Id, string Type)
        {
            string address = await AppContext.Execute<dynamic>(MethodType.GET, Path.Combine(_UrlApi, "GetAddress", Type, Id), null);
            return Json(address);
        }

        #region DataTableTravels

        [HttpPost]
        public async Task<JsonResult> DataTableTravels(DataTablesParameters dtParams)
        {
            TravelDTModel data = await AppContext.Execute<TravelDTModel>(MethodType.POST, Path.Combine(_UrlApi, "DataTableTravels"), dtParams);

            return Json(data);
        }
        #endregion
    }
}
