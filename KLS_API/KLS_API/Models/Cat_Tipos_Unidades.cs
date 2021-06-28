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

        public decimal mantenimiento { get; set; }

        public decimal llantas { get; set; }

        public decimal litros { get; set; }

        public decimal rendimiento { get; set; }

        public decimal limite_peso { get; set; }

        [Column(TypeName = "Varchar(35)")]
        public string limite_volumen { get; set; }
    }
}
