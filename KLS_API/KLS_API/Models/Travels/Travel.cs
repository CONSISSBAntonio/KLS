﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }
        public int IdOrigen { get; set; }
        public int IdDestino { get; set; }
        public int IdRuta { get; set; }
        public int IdUnidad { get; set; }
        public int IdTipoViaje { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string DireccionRemitente { get; set; }
        public string DireccionDestinatario { get; set; }

        //Extras
        public string OrdenCompra { get; set; }
        public string ReferenciaDos { get; set; }
        public string ReferenciaTres { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string HBL { get; set; }
        public string Intercom { get; set; }
        public ICollection<Services> Servicios { get; set; }
    }
}