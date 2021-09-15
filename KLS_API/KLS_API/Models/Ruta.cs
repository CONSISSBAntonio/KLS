using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_API.Models
{
    public class Ruta
    {
        [Key]
        public int id { get; set; }
        public int id_estadoorigen { get; set; }
        public int id_ciudadorigen { get; set; }
        public int id_estadodestino { get; set; }
        public int id_ciudaddestino { get; set; }
        public string Folio { get; set; }
        public int totalkilometros { get; set; }
        public int eficiencia { get; set; }
        public int tiemporuta { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string seguridad { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string demanda { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMinimo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMaximo { get; set; }
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
        public string URL { get; set; }
    }
}
