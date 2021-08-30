using KLS_WEB.Models.Carriers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels.DTO
{
    public class ServicesDTO
    {
        public string[] Services { get; set; }
        public SelectList Selects { get; set; } = new SelectList();

        public class SelectList
        {
            public List<SelectListItem> Carriers { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Drivers { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> UnitTypes { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Units { get; set; } = new List<SelectListItem>();
        }
    }
}
