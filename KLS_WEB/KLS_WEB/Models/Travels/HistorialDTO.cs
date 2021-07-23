using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class HistorialDTO
    {
        public int Id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public string Registro { get; set; }
        public string Usuario { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
