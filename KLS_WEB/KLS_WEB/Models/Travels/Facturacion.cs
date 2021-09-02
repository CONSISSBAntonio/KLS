using System;
using System.ComponentModel.DataAnnotations;

namespace KLS_WEB.Models.Travels
{
    public class Facturacion
    {
        [Key]
        public int id { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public string nombre { get; set; }
        public string fullpath { get; set; }
        public DateTime fechacarga { get; set; }
        public string usuario { get; set; }
    }
}
