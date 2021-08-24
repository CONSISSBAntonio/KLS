using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Models.DT;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Travels
{
    [Route("Travels/")]
    [Authorize]
    public class TravelsController : Controller
    {
        private string _UrlView = "~/Views/Travels/";
        private string _UrlApi = "Travels";

        private readonly IAppContextService AppContext;

        public TravelsController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public class SearchRuta
        {
            public int Id { get; set; }
            public string OD { get; set; }
            public int OrigenId { get; set; }
            public int DestinoId { get; set; }
        }

        [Route("[action]")]
        public async Task<JsonResult> GetRuta(SearchRuta search)
        {
            List<SearchRuta> route = await AppContext.Execute<List<SearchRuta>>(MethodType.POST, Path.Combine(_UrlApi, "GetRuta"), search);
            return Json(route);
        }


        [Route("SetHistorial")]
        public void SetHistorial(string accion)
        {
            int TravelId = (int)TempData.Peek("TravelId");
            var UserName = HttpContext.Session.GetString("UserFN");
            if (UserName != null && accion != null)
            {
                HistorialDTO historial = new HistorialDTO
                {
                    TravelId = TravelId,
                    Registro = accion,
                    Usuario = UserName,
                    TimeCreated = DateTime.Now
                };

                AppContext.Execute<HistorialDTO>(MethodType.POST, Path.Combine(_UrlApi, "SetHistorial"), historial);
            };

        }

        [Route("GetHistorial")]
        public async Task<IActionResult> GetHistorial(string TravelId)
        {
            List<HistorialDTO> historial = await AppContext.Execute<List<HistorialDTO>>(MethodType.GET, Path.Combine(_UrlApi, "GetHistorial", TravelId), null);
            return Json(historial);
        }

        [Route("[action]/{TravelId}")]
        public async Task<IActionResult> CartaPorte(string TravelId)
        {
            CartaPorteModel cartaPorte = await AppContext.Execute<CartaPorteModel>(MethodType.GET, Path.Combine(_UrlApi, "CartaPorte", TravelId), null);
            return new ViewAsPdf(cartaPorte);
        }

        [Route("GetEstatus")]
        public async Task<IActionResult> GetEstatus(int Id)
        {
            Travel travel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine(_UrlApi, "GetTravel", Id.ToString()), null);
            return Json(travel);
        }

        [Route("UpdateStatus")]
        public async Task<IActionResult> UpdateStatus(TravelDTO travelDTO)
        {
            TravelDTO travel = await AppContext.Execute<TravelDTO>(MethodType.PUT, Path.Combine(_UrlApi, "UpdateStatus"), travelDTO);
            SetHistorial(travelDTO.Estatus.ToLower() == "cerrado" ? travelDTO.Estatus : string.Concat(travelDTO.Estatus, ", ", travelDTO.SubEstatus));
            return Json(travel);
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "Index.cshtml");
        }

        [Route("GetMercancia/{id}")]
        public async Task<JsonResult> GetMercancia(int id)
        {
            MercanciaDTO mercancia = await AppContext.Execute<MercanciaDTO>(MethodType.GET, Path.Combine(_UrlApi, "GetMercancia", id.ToString()), null);

            return Json(mercancia);
        }

        //[Route("{id}")]
        //public async Task<IActionResult> AddEdit(int id)
        //{
        //    Travel travel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine(_UrlApi, "GetTravel", id.ToString()), null);
        //    TempData["TravelId"] = travel is null ? 0 : travel.Id;
        //    TempData.Keep();
        //    return View(this._UrlView + (id == 0 ? "New.cshtml" : "Details.cshtml"), travel == null ? new Travel() : travel);
        //}

        [Route("[action]")]
        public async Task<IActionResult> AddMainTravel(int id)
        {
            MainTravelDTO mainTravelDTO = new MainTravelDTO();

            var x = await AppContext.Execute<MainTravel>(MethodType.GET, Path.Combine(_UrlApi, "GetMainTravel", id.ToString()), null);
            var services = await AppContext.Execute<List<Cat_Tipos_Unidades>>(MethodType.GET, Path.Combine(_UrlApi, "GetTipoServicio"), null);

            foreach (var item in services)
            {
                SelectListItem service = new SelectListItem { Value = item.id.ToString(), Text = item.nombre };
                mainTravelDTO.Servicios.Add(service);
            }

            //TempData["TravelId"] = mainTravelDTO.MainTravel is null ? 0 : mainTravelDTO.MainTravel.Id;
            //TempData.Keep();

            return View(_UrlView + "New.cshtml", mainTravelDTO);
        }

        [Route("setMercancia")]
        public async Task<JsonResult> PostMercancia(MercanciaDTO mercanciaDTO)
        {
            MercanciaDTO mercancia = await AppContext.Execute<MercanciaDTO>(MethodType.POST, Path.Combine(_UrlApi, "PostMercancia"), mercanciaDTO);
            SetHistorial("mercancia actualizada");
            return Json(mercancia);
        }

        [Route("GetServicios/{id}")]
        public async Task<JsonResult> GetServicios(string id)
        {
            List<ServicesDTO> servicios = await AppContext.Execute<List<ServicesDTO>>(MethodType.GET, Path.Combine(_UrlApi, "GetServicios", id), null);
            return Json(servicios);
        }

        [HttpPost]
        [Route("getTravels")]
        public async Task<JsonResult> Get(DataTablesParameters param)
        {
            IEnumerable<TravelDT> dataReport = await AppContext.Execute<List<TravelDT>>(MethodType.GET, _UrlApi, null);

            long total = dataReport.Count();

            #region Búsqueda
            if (!string.IsNullOrEmpty(param.search.value[0]))
            {
                string keyword = param.search.value[0].ToLower();

                dataReport = dataReport.Where(x => x.Folio.ToLower().Contains(keyword) ||
                x.Cliente.ToLower().Contains(keyword) ||
                x.Origen.ToLower().Contains(keyword) ||
                x.Destino.ToLower().Contains(keyword) ||
                x.Salida.ToLower().Contains(keyword) ||
                x.Llegada.ToLower().Contains(keyword) ||
                x.Estatus.ToLower().Contains(keyword));
            }

            long totalFiltered = dataReport.Count();
            #endregion

            #region Ordenamiento
            int columnId = param.order[0].column[0];

            Func<TravelDT, string> orderFunction = (x => columnId == 0 ? x.Folio :
            columnId == 1 ? x.Cliente :
            columnId == 2 ? x.Origen :
            columnId == 3 ? x.Destino :
            columnId == 4 ? x.Salida :
            columnId == 5 ? x.Llegada :
            x.Estatus);

            dataReport = param.order[0].dir[0] == "asc" ? dataReport.OrderBy(orderFunction) : dataReport.OrderByDescending(orderFunction);
            #endregion

            #region Paginado
            dataReport.Skip(param.start).Take(param.length);
            #endregion

            #region DataTable
            List<TravelDT> data = dataReport.ToList();
            #endregion

            return Json(new
            {
                aaData = data,
                param.draw,
                iTotalRecords = total,
                iTotalDisplayRecords = totalFiltered
            });
        }

        [Route("DeleteService/{id}")]
        public async Task<JsonResult> DeleteService(string id)
        {
            ServicesDTO service = await AppContext.Execute<ServicesDTO>(MethodType.DELETE, Path.Combine(_UrlApi, "DeleteService", id), null);
            SetHistorial(string.Concat(service.Nombre, ", servicio eliminado"));
            return Json(service);
        }


        [Route("setTravels")]
        public async Task<JsonResult> Post(Travel dataModel)
        {
            List<ServicesDTO> services = new List<ServicesDTO>();
            List<UnidadDTO> units = new List<UnidadDTO>();
            int ViajeId = dataModel.Id != 0 ? dataModel.Id : 0;

            if (ViajeId == 0)
            {
                TravelDTO viaje = new TravelDTO
                {
                    Estatus = dataModel.Estatus,
                    Folio = dataModel.Folio,
                    IdCliente = dataModel.Cliente,
                    FechaSalida = dataModel.FechaSalida,
                    FechaLlegada = dataModel.FechaLlegada,
                    TiempoAnticipacion = dataModel.TiempoAnticipacion,
                    IdOrigen = dataModel.Origen,
                    DireccionRemitente = dataModel.DireccionRemitente,
                    IdDestino = dataModel.Destino,
                    DireccionDestinatario = dataModel.DireccionDestinatario,
                    CostoTotal = dataModel.Costototal,
                    PrecioClienteTotal = dataModel.Preciototal,
                    IdRuta = dataModel.Ruta,
                    IdUnidad = dataModel.TipoUnidad,
                    TipoViaje = dataModel.TipoViaje,
                    UsuarioEspejo = dataModel.UsuarioEspejo,
                    PassEspejo = dataModel.PassEspejo,
                    ReferenciaUno = dataModel.Referencia1,
                    ReferenciaDos = dataModel.Referencia2,
                    ReferenciaTres = dataModel.Referencia3,
                    SubEstatus = "Alta de Viaje",
                    StatusUpdated = DateTime.Now,
                    CreatedBy = HttpContext.Session.GetString("UserFN"),
                    TimeCreated = DateTime.Now
                };

                TravelDTO newTravel = await this.AppContext.Execute<TravelDTO>(MethodType.POST, _UrlApi, viaje);
                ViajeId = newTravel.Id;
                TempData["TravelId"] = ViajeId;
                TempData.Keep();
                SetHistorial("Alta de viaje");
            }

            if (dataModel.ServicesId != null)
            {
                foreach (var id in dataModel.ServicesId)
                {
                    if (id > 0)
                    {
                        ServicesDTO service = await AppContext.Execute<ServicesDTO>(MethodType.DELETE, Path.Combine(_UrlApi, "DeleteService", id.ToString()), null);
                    }
                }
            }

            var servicios = dataModel.Servicios.Split("&");

            foreach (var servicio in servicios)
            {
                string nombre = servicio.Replace("=on", "");

                ServicesDTO service = new ServicesDTO
                {
                    TravelId = ViajeId,
                    Nombre = nombre,
                    IdTransportista = dataModel.Transportista,
                    IdChofer = dataModel.Chofer,
                    Precio = dataModel.TerrestreNacionalPrecio,
                    Costo = dataModel.TerrestreNacionalCosto
                };

                ServicesDTO newService = await this.AppContext.Execute<ServicesDTO>(MethodType.POST, Path.Combine(_UrlApi, "PostService"), service);
                services.Add(newService);

                int IdServicio = newService.Id;

                var unidades = dataModel.Unidad.Split("&");
                var equipos = dataModel.Equipo.Split("&");
                int index = 0;
                foreach (var unidad in unidades)
                {
                    if (unidad.Contains(nombre))
                    {
                        string Id = new string(unidad.Where(char.IsDigit).ToArray());
                        string IdEquipo = new string(equipos[index].Where(char.IsDigit).ToArray());
                        UnidadDTO unidaddb = new UnidadDTO
                        {
                            IdUnidad = Convert.ToInt32(Id),
                            IdEquipo = Convert.ToInt32(IdEquipo),
                            ServicesId = IdServicio
                        };

                        UnidadDTO newUnity = await AppContext.Execute<UnidadDTO>(MethodType.POST, Path.Combine(_UrlApi, "PostUnit"), unidaddb);
                        units.Add(newUnity);
                        ++index;
                    }
                }
            }

            return Json(new { services, units });
        }

        [Route("putTravels")]
        public async Task<JsonResult> Put(Travel dataModel)
        {
            Travel dataReport;
            dataReport = await this.AppContext.Execute<Travel>(MethodType.PUT, _UrlApi, dataModel);
            return Json(dataReport);
        }

        [HttpGet]
        [Route("getCarrier")]
        public async Task<JsonResult> getCarrier(Transportista dataModel)
        {
            Transportista dataReport;
            dataReport = await this.AppContext.Execute<Transportista>(MethodType.GET, _UrlApi + "/getCarrier", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        public PartialViewResult ReturnServicios(Travel travel)
        {
            return PartialView(string.Concat(_UrlView, "_Servicios.cshtml"), travel);
        }


        public class RoutePrice
        {
            public decimal Minimo { get; set; }
            public decimal Maximo { get; set; }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<JsonResult> GetRoutePrice(string RouteId)
        {
            RoutePrice price = await AppContext.Execute<RoutePrice>(MethodType.GET, Path.Combine(_UrlApi, "GetRoutePrice", RouteId), null);
            return Json(price);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SetMainTravel(MainTravelDTO mainTravelDTO)
        {

            var services = await AppContext.Execute<List<Cat_Tipos_Unidades>>(MethodType.GET, Path.Combine(_UrlApi, "GetTipoServicio"), null);

            foreach (var item in services)
            {
                SelectListItem service = new SelectListItem { Value = item.id.ToString(), Text = item.nombre };
                mainTravelDTO.Servicios.Add(service);
            }

            mainTravelDTO.MainTravel.CreatedBy = HttpContext.Session.GetString("UserFN");
            //mainTravelDTO.MainTravel = await AppContext.Execute<MainTravel>(MethodType.POST, Path.Combine(_UrlApi, "SetMainTravel"), mainTravelDTO.MainTravel);

            return View(string.Concat(_UrlView, "New.cshtml"), mainTravelDTO);
        }
    }
}
