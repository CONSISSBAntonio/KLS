namespace KLS_WEB.Models.DT
{
    public class DemandModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int OriginId { get; set; }
        public int UnitId { get; set; }
        public int DestinationId { get; set; }
        public int RouteId { get; set; }
        public string Folio { get; set; }
        public string Cliente { get; set; }
        public string TipoUnidad { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaDisponibilidad { get; set; }
        public string Arribo { get; set; }
        public int OfertasCount { get; set; }
    }
}
