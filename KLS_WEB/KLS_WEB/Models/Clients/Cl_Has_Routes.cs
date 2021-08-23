using System.ComponentModel.DataAnnotations;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Routes
    {
        [Key]
        public int Id { get; set; }
        public int Id_Ruta { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Cliente_Kls { get; set; }
        public bool Monitoreable { get; set; }
        public int Estatus { get; set; }
    }
}
