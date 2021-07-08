using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Biblioteca
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Nombre { get; set; }
        public int Estatus { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Archivo { get; set; }
        [Column(TypeName = "varchar(155)")]
        public string Ruta { get; set; }
        public DateTime FechaEvento { get; set; }
    }
}
