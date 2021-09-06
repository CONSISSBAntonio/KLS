using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Monitoring
{
    public class Section_Has_Checkpoint
    {
        [Key]
        public int Id { get; set; }
        public int idSection { get; set; }
        public int idCheckpoint { get; set; }
        public DateTime HoraReal { get; set; }
        public string CreatedBy { get; set; }
    }
}
