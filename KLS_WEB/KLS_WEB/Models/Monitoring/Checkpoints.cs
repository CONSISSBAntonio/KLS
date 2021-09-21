using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Monitoring
{
    public class Checkpoints
    {
        public List<Ruta_Has_Checkpoint> ruta_Has_Checkpoint { get; set; }
        public List<Section_Has_Checkpoint> section_has_checkpoint { get; set; }
        public string fechasalida { get; set; }
        public int idviaje { get; set; }
        public int idruta { get; set; }
    }
}
