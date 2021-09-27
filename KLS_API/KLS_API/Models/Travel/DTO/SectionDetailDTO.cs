using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel.DTO
{
    public class SectionDetailDTO
    {
        public string Folio { get; set; }
        public string Transportista { get; set; }
        public string Conductor { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Telefono { get; set; }
        public string TipoDeUnidad { get; set; }
    }
}
