using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Demands
{
    public class Demand
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public int ClientId { get; set; }
        public int UnitId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public int RangoEspera { get; set; }
        public string NivelOrigen { get; set; }
        public int EstadoIdOrigen { get; set; }
        public int RegionIdOrigen { get; set; }
        public int CiudadIdOrigen { get; set; }
        public int ToleranciaOrigen { get; set; }
        public string NivelDestino { get; set; }
        public int EstadoIdDestino { get; set; }
        public int RegionIdDestino { get; set; }
        public int CiudadIdDestino { get; set; }
        public int ToleranciaDestino { get; set; }
        public string Arribo { get; set; }
        public string Status { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
