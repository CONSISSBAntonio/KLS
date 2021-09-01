using KLS_WEB.Models.Carriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Service
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        public int TransportistaId { get; set; }
        public Transportista Transportista { get; set; }
        public int Tr_Has_OperadoresId { get; set; }
        public Tr_Has_Operadores Tr_Has_Operadores { get; set; }
        public ICollection<Unit> Units { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
