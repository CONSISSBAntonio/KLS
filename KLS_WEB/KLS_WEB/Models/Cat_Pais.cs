using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_API.Models
{
    public class Cat_Pais
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(28)")]
        public string pais { get; set; }
        public int estatus { get; set; }
    }
}
