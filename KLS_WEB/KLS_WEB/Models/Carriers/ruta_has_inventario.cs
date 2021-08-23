using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Carriers
{
    public class ruta_has_inventario
    {
        [Key]
        public int Id { get; set; }
        public int Id_Tr_Has_RutasId { get; set; }
        public int Id_Inventario { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal CostoOne { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal CostoTwo { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal Circuito { get; set; }
    }
}