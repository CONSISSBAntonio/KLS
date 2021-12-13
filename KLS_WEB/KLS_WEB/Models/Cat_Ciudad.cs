using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_API.Models
{
    public class Cat_Ciudad
    {
        [Key]
        public int id { get; set; }
        public int id_pais { get; set; }
        public int id_estado { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string id_sepomex { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string ClaveSat { get; set; }

        [Column(TypeName = "varchar(35)")]
        public string nombre { get; set; }
        public int estatus { get; set; }
    }
}
