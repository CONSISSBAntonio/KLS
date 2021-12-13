using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class Cat_Estado
    {
        [Key]
        public int id { get; set; }

        public int id_pais { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string id_sepomex { get; set; }
        [Required]
        [Column(TypeName ="varchar(10)")]
        public string ClaveSat { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string nombre { get; set; }

        public int estatus { get; set; }
    }
}
