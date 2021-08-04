using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class Ruta
    {
        [Key]
        public int id { get; set; }
        public int id_estadoorigen { get; set; }
        public int id_ciudadorigen { get; set; }
        public int id_estadodestino { get; set; }
        public int id_ciudaddestino { get; set; }
        public int totalkilometros { get; set; }
        public int eficiencia { get; set; }
        public int tiemporuta { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string seguridad { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string demanda { get; set; }
        public int estatus { get; set; }

        //Monitoreo
        public int frecvalidacion { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string restriccioncirc { get; set; }
        [Column(TypeName = "text")]
        public string observaciones { get; set; }

        //Actualizaciones
        [Column(TypeName = "varchar(100)")]
        public string actualizadopor { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime? ultimocambio { get; set; }
    }
}
