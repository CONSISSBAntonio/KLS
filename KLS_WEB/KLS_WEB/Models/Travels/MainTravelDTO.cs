using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class MainTravelDTO
    {
        public MainTravel MainTravel { get; set; } = new MainTravel();
        public TravelDTO TravelDTO { get; set; } = new TravelDTO();
        public List<SelectListItem> Servicios { get; set; } = new List<SelectListItem> { (new SelectListItem { Disabled = true, Selected = true, Value = "0", Text = "SELECCIONA" }) };
        public string Type { get; set; } = "new";
        //public List<SelectListItem> Servicios { get; set; } = new List<SelectListItem> {
        //    (new SelectListItem { Disabled = true, Value = "0", Text = "SELECCIONA" }),
        //    (new SelectListItem { Value = "VTNOW", Text = "TERRESTRE NACIONAL ONE WAY" }),
        //    (new SelectListItem { Value = "VTNTW", Text = "TERRESTRE NACIONAL TWO WAY" }),
        //    (new SelectListItem { Value = "VTNC", Text = "TERRESTRE NACIONAL CIRCUITEABLE" }),
        //    (new SelectListItem { Value = "VTI", Text = "TERRESTRE INTERNACIONAL" }),
        //    (new SelectListItem { Value = "VM", Text = "MARÍTIMO" }),
        //    (new SelectListItem { Value = "VA", Text = "AÉREO" }),
        //    (new SelectListItem { Value = "VMM", Text = "MULTIMODAL" })
        //};
    }
}
