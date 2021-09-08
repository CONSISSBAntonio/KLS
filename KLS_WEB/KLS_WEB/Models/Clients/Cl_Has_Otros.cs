using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Otros
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public bool Mandatario1 { get; set; }
        public bool Mandatario2 { get; set; }
        public bool Mandatario3 { get; set; }
        public bool Referencia1 { get; set; }
        public bool Referencia2 { get; set; }
        public bool Referencia3 { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Treferencia1 { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Treferencia2 { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string
            Treferencia3
        { get; set; }
    }
}
