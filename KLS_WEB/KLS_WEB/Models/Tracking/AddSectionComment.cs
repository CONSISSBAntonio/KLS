using KLS_WEB.Models.Travels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Tracking
{
    public class AddSectionComment
    {
        public int SectionId { get; set; }
        public int SubstatusId { get; set; }
        public string Comment { get; set; }
        public string GrupoMonitor { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<Evidence> Evidences { get; set; } = new Collection<Evidence>();
        public List<IFormFile> File { get; set; }
    }
}
