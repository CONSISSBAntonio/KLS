using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class Paginacion
    {
        public int Pagina { get; set; }
        public int CantidadAMostrar { get; set; }
        public string Buscar { get; set; }
        public string Ordenar { get; set; }
    }
}
