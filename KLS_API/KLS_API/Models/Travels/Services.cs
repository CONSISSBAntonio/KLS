﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Services
    {
        //Terrestre nacional / Internacional
        [Key]
        public int Id { get; set; }
        public int IdTravel { get; set; }
        public string Nombre { get; set; }
        public int IdTransportista { get; set; }
        public int IdChofer { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Precio { get; set; }

        //Cálculos
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoTotal { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioClienteTotal { get; set; }
        public List<Unidad> Unidades { get; set; }

        //Costos/Precios Terrestre internacional
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoTI { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioTI { get; set; }

        // Naviera
        public int IdNaviera { get; set; }
        public string Buque { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoN { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioN { get; set; }

        //Agente aduanal
        public int IdAgenteAduanal { get; set; }
        public int IdContactoAA { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoAA { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioAA { get; set; }

        //Aerolinea
        public int IdAerolinea { get; set; }
        public int IdContactoA { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoA { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioA { get; set; }

        //Coloader
        public int IdCoLoader { get; set; }
        public int IdContactoCL { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostoCL { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioCL { get; set; }
    }
}
