using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class AddSectionComment
    {
        public int SectionId { get; set; }
        public int SubstatusId { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public List<Evidence> Evidences { get; set; } = new List<Evidence>();
        public ICollection<IFormFile> File { get; set; }
    }
}
