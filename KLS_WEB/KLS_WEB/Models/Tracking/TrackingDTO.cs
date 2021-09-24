using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Tracking
{
    public class TrackingDTO
    {
        public int Todos { get; set; }
        public int Confirmados { get; set; }
        public int EnTransito { get; set; }
        public int Demorados { get; set; }
        public InitSelects Selects { get; set; } = new InitSelects();
        public class InitSelects
        {
            public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Statuses { get; set; } = new List<SelectListItem>();
        }
    }
}
