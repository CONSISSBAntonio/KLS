using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel.DTO
{
    public class TrackingDT
    {
        public int SectionId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public int SubstatusId { get; set; }
        public string Folio { get; set; }
        public string Cliente { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string FechaLlegada { get; set; }
        public string SiguienteContacto { get; set; }
        public string ETA { get; set; }
        public string GrupoMonitor { get; set; }
        public string Status { get; set; }
        public string Checkpoint { get; set; }
    }
}
