using KLS_WEB.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels.DTO
{
    public class BoxDTO
    {
        public int SectionId { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public decimal Largo { get; set; }
        public decimal Peso { get; set; }
        public decimal PesoVolumetrico { get; set; }
        public Cl_Has_Box Cl_Has_Box { get; set; } = new Cl_Has_Box();
    }
}
