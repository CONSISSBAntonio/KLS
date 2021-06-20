using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class Cat_Subservicios
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string servicio { get; set; }
        public int estatus { get; set; }
    }
}
