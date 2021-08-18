using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Carriers
{
    public class ruta_has_inventario
    {
        [Key]
        public int Id { get; set; }
        public int Tr_Has_RutaId { get; set; }
        public int Id_Inventario { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal CostoOne { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public Decimal CostoTwo { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Circuito { get; set; }

    }
}
