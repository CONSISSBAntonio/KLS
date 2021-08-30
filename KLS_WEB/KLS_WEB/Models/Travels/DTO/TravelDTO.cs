using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels.DTO
{
    public class TravelDTO
    {
        public Travel Travel { get; set; } = new Travel();
        public ICollection<Section> Sections { get; set; } = new Collection<Section>();
        public Section Section { get; set; } = new Section();
        public InitSelects Selects { get; set; } = new InitSelects();
        public class InitSelects
        {
            public List<SelectListItem> Cat_Tipos_Unidades { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> CustomerOrigins { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> CustomerDestinations { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Routes { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> SectionType { get; set; } = new List<SelectListItem>();
        }

    }
}
