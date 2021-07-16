using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string NombreComercial { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string NombreCorto { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string RazonSocial { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Rfc { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string DireccionFiscal { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Sector { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string InegiDenue { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Industria { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Tamanio { get; set; }
        public int Estatus { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string PaginaWeb { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Facebook { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string OtraRed { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Banco { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Cuenta { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Ejecutivo { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Comentario { get; set; }
    }
}
