using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Evidencia
    {
        [Key]
        public int Id { get; set; }
        public int Estatus { get; set; }
        public int Id_Cliente { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Nombre { get; set; }
        public int Tiempo_Entrega { get; set; }
        public bool Fisica { get; set; }
        public bool Mandatario { get; set; }
    }
}
