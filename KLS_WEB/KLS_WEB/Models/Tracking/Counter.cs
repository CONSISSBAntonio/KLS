using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Tracking
{
    public class Counter
    {
        public int Confirmados { get; set; }
        public int EnTransito { get; set; }
        public int Demorados { get; set; }
    }
}
