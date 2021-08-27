using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Tramo
    {
        public TravelDTO Travel { get; set; } = new TravelDTO();
        public List<SelectListItem> Clients { get; set; } = new List<SelectListItem> { (new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" }) };
    }
}
