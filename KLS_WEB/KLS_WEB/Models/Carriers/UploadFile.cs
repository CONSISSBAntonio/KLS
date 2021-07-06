using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class UploadFile
    {
        [Key]
        public int Id { get; set; }
        public int IdTransportista { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Anio { get; set; }
        [Column(TypeName = "varchar(35)")]
        public string Capacidad { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Color { get; set; }
        public int Estatus { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Marca { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Modelo { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string NoEconomico { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string NoSerie { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Placa { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string TipoUnidad { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Volumen { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string FotoUnidad { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string FotoPoliza { get; set; }
        public List<IFormFile> Lista { get; set; }
    }
}
