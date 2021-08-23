using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLS_WEB.Models
{
    public class Cat_Region
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string nombre { get; set; }
        public List<Region_Has_Estado> Region_Has_Estados { get; set; }
        public int estatus { get; set; }
    }
}
