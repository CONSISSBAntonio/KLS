using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class Transportista
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(55)")]
        public string NombreComercial { get; set; }

        [Column(TypeName = "varchar(22)")]
        public string Tamanio { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Servicio { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string GradoConfiabilidad { get; set; }
        public int NivelServicio { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Comentario { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string FechaUltimoViaje { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string RazonSocial { get; set; }
        public int Estatus { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Rfc { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string DireccionFiscal { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string DireccionOficinas { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string DireccionPatio { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string GoogleMaps { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string PaginaWeb { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Facebook { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string OtraRed { get; set; }

        [Column(TypeName = "varchar(90)")]
        public string Banco { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Cuenta { get; set; }

        [Column(TypeName = "varchar(35)")]
        public string UsuarioMaster { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Contrasena { get; set; }
    }
}
