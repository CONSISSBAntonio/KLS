using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KLS_WEB.Models.Travels
{
    public class ServicesDTO
    {
        //Terrestre nacional / Internacional
        [Key]
        public int Id { get; set; }
        public int TravelId { get; set; }
        public string Nombre { get; set; }
        public int IdTransportista { get; set; }
        public int IdChofer { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public List<UnidadDTO> Unidades { get; set; }

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
