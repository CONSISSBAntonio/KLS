using System;

namespace KLS_WEB.Models.Travels
{
    public class TravelDT
    {
        public int Id { get; set; }
        public int MainTravelId { get; set; }
        public string Folio { get; set; }
        public string Cliente { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Salida => FechaSalida.ToString("dd/MM/yyyy. hh:mm tt");
        public string Llegada => FechaLlegada.ToString("dd/MM/yyyy. hh:mm tt");
        public string Estatus { get; set; }
    }
}
