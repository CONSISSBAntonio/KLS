using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class AddUser : IdentityUser
    {
        [Column(TypeName = "varchar(25)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Apaterno { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Amaterno { get; set; }
    }
}
