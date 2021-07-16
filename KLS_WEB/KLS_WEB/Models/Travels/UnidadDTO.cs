using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class UnidadDTO
    {
        public int Id { get; set; }
        public int IdUnidad { get; set; }
        public int IdEquipo { get; set; }
        public int ServicesId { get; set; }
        public ServicesDTO Services { get; set; }
    }
}
