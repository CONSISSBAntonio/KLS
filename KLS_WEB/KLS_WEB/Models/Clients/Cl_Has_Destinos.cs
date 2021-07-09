using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Destinos
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Nombre { get; set; }
        public int Cp { get; set; }
        public int Id_Estado { get; set; }
        public int Id_Ciudad { get; set; }
        public int Id_Colonia { get; set; }
        [Column(TypeName = "varchar(120)")]
        public string Direccion { get; set; }
        public int Estatus { get; set; }
    }
}
