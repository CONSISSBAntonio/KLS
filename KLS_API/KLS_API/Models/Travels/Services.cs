using System;
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
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public string Nombre { get; set; }
        public int IdTransportista { get; set; }
        public int IdChofer { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Precio { get; set; }
        public List<Unidad> Unidades { get; set; }

        // Naviera
        public int IdNaviera { get; set; }
        public string Buque { get; set; }

        //Agente aduanal
        public int IdAgenteAduanal { get; set; }
        public int IdContactoAA { get; set; }

        //Aerolinea
        public int IdAerolinea { get; set; }
        public int IdContactoA { get; set; }

        //Coloader
        public int IdCoLoader { get; set; }
        public int IdContactoCL { get; set; }
    }
}
