using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class Cat_Tipos_Unidades
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }

        public int ejes { get; set; }

        public int estatus { get; set; }

        [Column(TypeName = "Decimal(11,4)")]
        public decimal mantenimiento { get; set; }

        [Column(TypeName = "Decimal(11,4)")]
        public decimal llantas { get; set; }

        [Column(TypeName = "Decimal(11,4)")]
        public decimal litros { get; set; }
        [Column(TypeName = "Decimal(11,4)")]
        public decimal rendimiento { get; set; }
        [Column(TypeName = "Decimal(11,4)")]
        public decimal limite_peso { get; set; }

        [Column(TypeName = "Varchar(35)")]
        public string limite_volumen { get; set; }
    }
}
