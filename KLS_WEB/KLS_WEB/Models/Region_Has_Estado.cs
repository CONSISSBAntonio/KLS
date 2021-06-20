using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class Region_Has_Estado
    {
        public int id {get;set;}
        public int Cat_RegionId { get; set; }
        public int id_estado { get; set; }
    }
}
