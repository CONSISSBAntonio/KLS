using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class Cat_Colonia
    {
        [Key]
        public int id { get; set; }
        public int id_estado { get; set; }
        public int id_ciudad { get; set; }
        public int cp { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string ClaveSat { get; set; }
        public int estatus { get; set; }
    }
}
