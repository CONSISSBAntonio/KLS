﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Facturacion
    {
        [Key]
        public int id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        [Column(TypeName = "VARCHAR(300)")]
        public string nombre { get; set; }
        public string fullpath { get; set; }
        public DateTime fechacarga { get; set; }
        public string usuario { get; set; }
    }
}
