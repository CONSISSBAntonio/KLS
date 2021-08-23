using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_API.Models.DTO
{
    public class UserDTO
    {
        public string Id_User { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Apaterno { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Amaterno { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Rol { get; set; }
        public int activo { get; set; }
    }
}
