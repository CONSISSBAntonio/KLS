using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_API.Models
{
    public class Cat_Tipos_Unidades
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }

        public int ejes { get; set; }

        public int estatus { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal mantenimiento { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal llantas { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal litros { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal rendimiento { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal limite_peso { get; set; }

        [Column(TypeName = "Varchar(35)")]
        public string limite_volumen { get; set; }
    }
}
