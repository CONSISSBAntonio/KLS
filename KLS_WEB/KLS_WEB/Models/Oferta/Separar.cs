using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Oferta
{
    public class Separar
    {
        [Key]
        public int id { get; set; }
        public int id_oferta { get; set; }
        [Column(TypeName = "varchar(120)")]
        public string rutaTentativa { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string notasCargo { get; set; }
    }
}
