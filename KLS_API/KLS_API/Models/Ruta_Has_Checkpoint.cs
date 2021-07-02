using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models
{
    public class Ruta_Has_Checkpoint
    {
        [Key]
        public int id { get; set; }
        public int RutaId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        public int tiempo { get; set; }
    }
}
