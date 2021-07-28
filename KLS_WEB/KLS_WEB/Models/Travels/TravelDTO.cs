using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class TravelDTO
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string TiempoAnticipacion { get; set; }
        public int IdOrigen { get; set; }
        public string DireccionRemitente { get; set; }
        public int IdDestino { get; set; }
        public string DireccionDestinatario { get; set; }
        public int IdRuta { get; set; }
        public int IdUnidad { get; set; }
        public string TipoViaje { get; set; }
        public string ReferenciaUno { get; set; }
        public string ReferenciaDos { get; set; }
        public string ReferenciaTres { get; set; }
        public string Estatus { get; set; }
        public string SubEstatus { get; set; }
        public DateTime StatusUpdated { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal PrecioClienteTotal { get; set; }
    }
}
