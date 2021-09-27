using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel.DTO
{
    public class CheckpointsDTO
    {
        public string Checkpoint { get; set; }
        public string HoraOriginal { get; set; }
        public string HoraEsperada { get; set; }
        public string HoraReal { get; set; }
        public string Usuario { get; set; }
    }
}
