using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Travel
    {
        public int Chofer { get; set; }
        public int Cliente { get; set; }
        public int Destino { get; set; }
        public string DireccionDestinatario { get; set; }
        public string DireccionRemitente { get; set; }
        public string Equipo { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string OrdenCompra { get; set; }
        public int Origen { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public int Ruta { get; set; }
        public string Servicios { get; set; }
        public decimal TerrestreNacionalPrecio { get; set; }
        public decimal TerrestreNacionalCosto { get; set; }
        public int TipoUnidad { get; set; }
        public string TipoViaje { get; set; }
        public int Transportista { get; set; }
        public string Unidad { get; set; }
        public string Folio { get; set; }
        public string Estatus { get; set; }
    }
}
