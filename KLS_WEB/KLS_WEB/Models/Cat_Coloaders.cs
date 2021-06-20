using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class Cat_Coloaders
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string direccion { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string telefono { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string departamento { get; set; }

        [Column(TypeName = "varchar(70)")]
        public string contacto { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string correo { get; set; }

        public int estatus { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string notas { get; set; }
    }
}
