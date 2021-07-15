using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class Unidad
    {
        [Key]
        public int Id { get; set; }
        public int IdUnidad { get; set; }
        public int IdEquipo { get; set; }
        public int ServicesId { get; set; }
        public Services Services { get; set; }
    }
}
