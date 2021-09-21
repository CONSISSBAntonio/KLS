using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Monitoring
{
    public class InfoMonitor
    {
        public string viaje { get; set; }
        public string transportista { get; set; }
        public string conductor { get; set; }
        public string direccionOrigen { get; set; }
        public string direccionDestino { get; set; }
        public string telefono { get; set; }
        public string tipoUnidad { get; set; }
    }
}
