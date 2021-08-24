using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class MainTravel
    {
        [Key]
        public int Id { get; set; }
        public string ServiceId { get; set; }
        public string Ejecutivo { get; set; }
        public string GrupoMonitor { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
        public IEnumerable<Travel> Travels { get; set; }
    }
}
