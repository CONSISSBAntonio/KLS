using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class Travel
    {
        public int Id { get; set; }
        public int SubstatusId { get; set; }
        public Substatus Substatus { get; set; }
        [Required]
        public int TravelServiceId { get; set; }
        public TravelService TravelService { get; set; }
        public string Folio { get; set; }
        public ICollection<Section> Sections { get; set; }
        public string Ejecutivo { get; set; }
        public string GrupoMonitor { get; set; }
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
