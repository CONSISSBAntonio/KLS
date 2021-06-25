using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using KLS_API.Models;
using KLS_WEB.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KLS_WEB.Models
{
    public class Route
    {
        [Key]
        public int id { get; set; }
        public int id_estadoorigen { get; set; }
        public int id_ciudadorigen { get; set; }
        public int id_estadodestino { get; set; }
        public int id_ciudaddestino { get; set; }
        public int totalkilometros { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string eficiencia { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string totalhoras { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string seguridad { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string demanda { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string tipodeviaje { get; set; }
        public int estatus { get; set; }

        //Monitoreo
        [Column(TypeName = "varchar(100)")]
        public string frecvalidacion { get; set; }
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
