using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Carriers
{
    public class Tr_Has_Contactos
    {
        [Key]
        public int Id { get; set; }
        public int Id_Transportista { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string TipoContacto { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(35)")]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string Correo { get; set; }
        public int Estatus { get; set; }
    }
}
