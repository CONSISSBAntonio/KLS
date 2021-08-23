using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Travel
    {
        public int Id { get; set; }
        public int Chofer { get; set; }
        public int Cliente { get; set; }
        public int Destino { get; set; }
        public string DireccionDestinatario { get; set; }
        public string DireccionRemitente { get; set; }
        public string Equipo { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string TiempoAnticipacion { get; set; }
        public int Origen { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public int Ruta { get; set; }
        public int TiempoRuta { get; set; }
        public string Servicios { get; set; }
        public decimal TerrestreNacionalPrecio { get; set; }
        public decimal TerrestreNacionalCosto { get; set; }
        public decimal Costototal { get; set; }
        public decimal Preciototal { get; set; }
        public int TipoUnidad { get; set; }
        public string TipoViaje { get; set; }
        public string UsuarioEspejo { get; set; }
        public string PassEspejo { get; set; }
        public int Transportista { get; set; }
        public string Unidad { get; set; }
        public string Folio { get; set; }
        public string Estatus { get; set; }
        public string SubEstatus { get; set; }
        public DateTime StatusUpdated { get; set; }

        //Detail
        public string NombreCliente { get; set; }
        public string NombreRuta { get; set; }
        public string TipoUnidadNombre { get; set; }
        public string Salida => FechaSalida.ToString("dd/MM/yyyy. hh:mm tt");
        public string Llegada => FechaLlegada.ToString("dd/MM/yyyy. hh:mm tt");
        public int ClienteId { get; set; }
        public string Ejecutivo { get; set; }
        public string ChoferNombre { get; set; }
        public string ChoferTelefono { get; set; }

        // ServicesId para details
        public string ServiciosIds { get; set; }
        public List<int> ServicesId { get; set; }
        public bool IsDemand { get; set; }
        public bool IsOffer { get; set; }

    }
}
