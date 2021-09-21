using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel.DTO
{
    public class TravelDT
    {
        public int Id { get; set; }
        public int MainTravelId { get; set; }
        public string Folio { get; set; }
        public string Cliente { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string FechaLlegada { get; set; }
        public string Estatus { get; set; }
        public int SubstatusId { get; set; }
    }
}
