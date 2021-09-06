using KLS_API.Models.Clients;
using KLS_API.Models.Travel;
using System;

namespace KLS_API.Models.Demands
{
    public class Demand
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Clientes Client { get; set; }
        public int TravelServiceId { get; set; }
        public virtual TravelService TravelService { get; set; }
        public int OriginId { get; set; }
        public virtual Cl_Has_Origen Origin { get; set; }
        public int DestinationId { get; set; }
        public virtual Cl_Has_Destinos Destination { get; set; }
        public int RouteId { get; set; }
        public virtual Ruta Route { get; set; }
        public string Folio { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Arribo { get; set; }
        public string TipoViaje { get; set; }
        public string Status { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
