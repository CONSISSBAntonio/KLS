using KLS_API.Models.Carriers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class Service
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public int TransportistaId { get; set; }
        public virtual Transportista Transportista { get; set; }
        public int Tr_Has_OperadoresId { get; set; }
        public virtual Tr_Has_Operadores Tr_Has_Operadores { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
