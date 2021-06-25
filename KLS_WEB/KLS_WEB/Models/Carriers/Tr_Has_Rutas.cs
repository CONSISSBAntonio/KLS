using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class Tr_Has_Rutas
    {
        [Key]
        public int Id { get; set; }
        public int Id_Transportista { get; set; }
        public int Id_Origen { get; set; }
        public int Id_Destino { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal Total_Kilometros { get; set; }
        public int Eficiencia { get; set; }
        public int TotalHoras { get; set; }
        public int Seguridad { get; set; }
        public int Demanda { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Restriccion { get; set; }
        public int TipoDeViaje { get; set; }
        public int Estatus { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string FrecValidacion { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string RestriccionCircuito { get; set; }
        [Column(TypeName = "varchar(85)")]
        public string Observacion { get; set; }
    }
}
