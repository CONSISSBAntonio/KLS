using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Mercancia
    {
        public int Id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Alto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ancho { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Largo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Peso { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PesoVolumetrico { get; set; }
    }
}
