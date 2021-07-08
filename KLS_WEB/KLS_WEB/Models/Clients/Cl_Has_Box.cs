using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Box
    {
        [Key]
        public int Id { get; set; }
        public bool Custodia { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string D_Opcional { get; set; }
        public bool Densidad { get; set; }
        public bool Derramable { get; set; }
        public int Id_Cliente { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string M_Opcional { get; set; }
        public bool Material { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Notas { get; set; }

        public bool OlorPenetrante { get; set; }
        public bool Peligroso { get; set; }
        public bool TipoPresentacion { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string Tp_Opcional { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string V_Opcional { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string Valor { get; set; }
    }
}
