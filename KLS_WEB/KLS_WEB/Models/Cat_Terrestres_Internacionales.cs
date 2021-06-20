using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class Cat_Terrestres_Internacionales
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string departamento { get; set; }
        public string contacto { get; set; }
        public string correo { get; set; }
        public int estatus { get; set; }
        public string notas { get; set; }
    }
}
