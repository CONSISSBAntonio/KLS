using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Clients
{
    public class Cl_Has_Certificacion
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public bool Ctpat { get; set; }
        public bool Otro { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string C_Opcional { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string O_Opcional { get; set; }
    }
}
