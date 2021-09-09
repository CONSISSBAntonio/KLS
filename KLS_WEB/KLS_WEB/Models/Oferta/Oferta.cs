using KLS_WEB.Models.Travels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models.Oferta
{
    public class Oferta
    {
        [Key]
        public int Id { get; set; }
        public int IdServiceTypes { get; set; }
        public int? SectionId { get; set; }
        public virtual Section Section { get; set; }
        public int Transportista { get; set; }
        public int Tipo_De_Unidad { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_Disponibilidad { get; set; }
        public int Rango_De_Espera { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nivel_Origen { get; set; }
        public int Region_Origen { get; set; }
        public int Estado_Origen { get; set; }
        public int ciudad_Origen { get; set; }
        public int Tolerancia_Origen { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nivel_Destino { get; set; }
        public int Region_Destino { get; set; }
        public int estado_Destino { get; set; }
        public int ciudad_Destino { get; set; }
        public int Tolerancia_Destino { get; set; }
        public int status { get; set; }
    }

}
