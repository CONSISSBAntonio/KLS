namespace KLS_WEB.Models.Travels
{
    public class MercanciaDTO
    {
        public int Id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public decimal Largo { get; set; }
        public decimal Peso { get; set; }
        public decimal PesoVolumetrico { get; set; }
    }
}
