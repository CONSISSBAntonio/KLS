using System;

namespace KLS_WEB.Models.Search
{
    public class Search
    {
        public int ClienteId { get; set; }
        public int TipoUnidadId { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Rango { get; set; }
        public int EstadoOrigenId { get; set; }
        public int CiudadOrigenId { get; set; }
        public int EstadoDestinoId { get; set; }
        public int CiudadDestinoId { get; set; }
        public string TamanioEmpresa { get; set; }
    }
}