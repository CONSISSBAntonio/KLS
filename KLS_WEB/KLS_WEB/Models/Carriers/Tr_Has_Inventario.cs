﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Carriers
{
    public class Tr_Has_Inventario
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
        public int TipoUnidad { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Volumen { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Ruta { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string FotoUnidad { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string FotoPoliza { get; set; }

        public string TipoUnidadNombre { get; set; }
    }
}
