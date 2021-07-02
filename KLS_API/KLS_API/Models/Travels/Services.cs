using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int IdTransportista { get; set; }
        public int IdChofer { get; set; }
        public int MyProperty { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

        //Cálculos
        public decimal CostoTotal { get; set; }
        public decimal PrecioClienteTotal { get; set; }
        public ICollection<Unidad> Unidades { get; set; }

        //Costos/Precios Terrestre internacional
        public decimal CostoTI { get; set; }
        public decimal PrecioTI { get; set; }

        // Naviera
        public int IdNaviera { get; set; }
        public string Buque { get; set; }
        public decimal CostoN { get; set; }
        public decimal PrecioN { get; set; }

        //Agente aduanal
        public int IdAgenteAduanal { get; set; }
        public int IdContactoAA { get; set; }
        public decimal CostoAA { get; set; }
        public decimal PrecioAA { get; set; }

        //Aerolinea
        public int IdAerolinea { get; set; }
        public int IdContactoA { get; set; }
        public decimal CostoA { get; set; }
        public decimal PrecioA { get; set; }

        //Coloader
        public int IdCoLoader { get; set; }
        public int IdContactoCL { get; set; }
        public decimal CostoCL { get; set; }
        public decimal PrecioCL { get; set; }
    }
}
