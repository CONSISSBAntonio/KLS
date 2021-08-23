using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "varchar(250)")]
        public string id_User { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string nombre { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime? fecha { get; set; }
    }
}
