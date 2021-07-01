﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Carriers
{
    public class Tr_Has_Ruta
    {
        [Key]
        public int Id { get; set; }
        public int Id_Ruta { get; set; }
        [Column(TypeName = "decimal(2,2)")]
        public decimal Costo { get; set; }
        public int Estatus { get; set; }
    }
}