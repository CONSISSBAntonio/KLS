using System.ComponentModel.DataAnnotations;

namespace KLS_API.Models
{
    public class Cat_Subservicios
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string servicio { get; set; }
        public int estatus { get; set; }
    }
}
