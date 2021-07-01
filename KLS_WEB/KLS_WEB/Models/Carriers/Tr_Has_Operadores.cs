﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
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
        [Column(TypeName = "varchar(15)")]
        public int NoTelefono { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string SeguroSocial { get; set; }
        public int estatus { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string nombre { get; set; }
    }
}