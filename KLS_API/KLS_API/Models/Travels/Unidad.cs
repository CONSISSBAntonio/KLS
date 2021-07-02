using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Unidad
    {
        [Key]
        public int Id { get; set; }
        public int IdServicio { get; set; }
        public int IdTipo { get; set; }
        public int IdEquipo { get; set; }
    }
}
