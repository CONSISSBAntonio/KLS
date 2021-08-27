using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class MainTravel
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public string ServiceId { get; set; }
        public string Ejecutivo { get; set; }
        public string GrupoMonitor { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Status { get; set; }
        public string Subestatus { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
        public IEnumerable<Travel> Travels { get; set; } = Enumerable.Empty<Travel>();
    }
}
