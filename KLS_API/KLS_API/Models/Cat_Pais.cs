using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
