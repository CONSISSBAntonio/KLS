using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class Ruta_Has_Checkpoint
    {
        [Key]
        public int id { get; set; }
        public int RutaId { get; set; }
        public int Cat_CiudadId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string tiempo { get; set; }
    }
}
