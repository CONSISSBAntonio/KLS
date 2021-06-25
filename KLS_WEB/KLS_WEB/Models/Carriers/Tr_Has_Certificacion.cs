using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Carriers
{
    public class Tr_Has_Certificacion
    {
        [Key]
        public int Id { get; set; }
        public int Id_Transportista { get; set; }
        public bool Ctpat { get; set; }
        public bool Otro { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string C_Opcional { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string O_Opcional { get; set; }
    }
}
