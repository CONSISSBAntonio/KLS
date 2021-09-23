using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels.DTO
{
    public class SectionCommentDTO
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SubstatusId { get; set; }
        public Substatus Substatus { get; set; }
        public string Comment { get; set; }
        public ICollection<Evidence> Evidences { get; set; }
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }

        public string GrupoMonitor { get; set; }
    }
}
