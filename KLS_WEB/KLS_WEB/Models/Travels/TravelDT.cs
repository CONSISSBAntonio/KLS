using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class TravelDT
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public string Cliente { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Salida => FechaSalida.ToString("g");
        public string Llegada => FechaLlegada.ToString("g");
        public string Estatus { get; set; }
    }
}
