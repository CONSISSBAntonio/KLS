using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Rol { get; set; }
    }
}
