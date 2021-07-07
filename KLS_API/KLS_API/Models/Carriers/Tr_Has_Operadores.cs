using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Carriers
{
    public class Tr_Has_Operadores
    {
        [Key]
        public int Id { get; set; }
        public int Id_Transportista { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Imss { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string NoLicencia { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string NoIne { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string FotoLicencia { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string FotoIne { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string FotoSeguro { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Ruta { get; set; }
        public int NoTelefono { get; set; }
        public int estatus { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string nombre { get; set; }
    }
}
