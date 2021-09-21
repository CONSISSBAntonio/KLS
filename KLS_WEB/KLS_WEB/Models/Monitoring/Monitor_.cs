using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Monitoring
{
    public class Monitor_
    {
        public string folio { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string fechallegada { get; set; }
        public string fechallegada_ { get; set; }
        public string estatus { get; set; }
        public int estatusId { get; set; } //Estatus
        public string substatus { get; set; }
        public int subestatusId { get; set; }
        public int idviaje { get; set; }
        public string cliente { get; set; }
        public string fechasalida { get; set; }
        public int tiemporuta { get; set; }
        public int idcliente { get; set; }
        public int idruta { get; set; }
        public int frecuenciaValidacion { get; set; }
    }
}
