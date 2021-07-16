using KLS_WEB.Models;
using KLS_WEB.Models.Carriers;
using KLS_WEB.Models.Travels;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [Route("{id}")]
        public async Task<IActionResult> AddEdit(int id)
        {
            Travel travel = await AppContext.Execute<Travel>(MethodType.GET, Path.Combine(_UrlApi, "GetTravel", id.ToString()), null);
            TempData["TravelId"] = travel is null ? 0 : travel.Id;
            return View(this._UrlView + (id == 0 ? "New.cshtml" : "Details.cshtml"), travel);
        }

        [Route("setMercancia")]
        public async Task<JsonResult> PostMercancia(MercanciaDTO mercanciaDTO)
        {
            MercanciaDTO mercancia = await AppContext.Execute<MercanciaDTO>(MethodType.POST, Path.Combine(_UrlApi, "PostMercancia"), mercanciaDTO);

            return Json(mercancia);
        }

        [Route("GetServicios/{id}")]
        public async Task<JsonResult>GetServicios(string id)
        {
            List<ServicesDTO> servicios = await AppContext.Execute<List<ServicesDTO>>(MethodType.GET, Path.Combine(_UrlApi, "GetServicios", id), null);
            return Json(servicios);
        }

        [Route("getTravels")]
        public async Task<JsonResult> Get()
        {
            List<TravelDT> dataReport = await this.AppContext.Execute<List<TravelDT>>(MethodType.GET, _UrlApi, null);
            return Json(dataReport);
        }

        [Route("setTravels")]
        public async Task<JsonResult> Post(Travel dataModel)
        {
            List<ServicesDTO> services = new List<ServicesDTO>();
            List<UnidadDTO> units = new List<UnidadDTO>();

            TravelDTO viaje = new TravelDTO
            {
                Estatus = dataModel.Estatus,
                Folio = dataModel.Folio,
                IdCliente = dataModel.Cliente,
                FechaSalida = dataModel.FechaSalida,
                FechaLlegada = dataModel.FechaLlegada,
                IdOrigen = dataModel.Origen,
                DireccionRemitente = dataModel.DireccionRemitente,
                IdDestino = dataModel.Destino,
                DireccionDestinatario = dataModel.DireccionDestinatario,
                CostoTotal = dataModel.Costototal,
                PrecioClienteTotal = dataModel.Preciototal,
                IdRuta = dataModel.Ruta,
                IdUnidad = dataModel.TipoUnidad,
                TipoViaje = dataModel.TipoViaje,
                OrdenCompra = dataModel.OrdenCompra,
                ReferenciaDos = dataModel.Referencia2,
                ReferenciaTres = dataModel.Referencia3
            };

            TravelDTO newTravel = await this.AppContext.Execute<TravelDTO>(MethodType.POST, _UrlApi, viaje);

            int ViajeId = newTravel.Id;

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

            return Json(new { newTravel, services, units });
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

    }
}
