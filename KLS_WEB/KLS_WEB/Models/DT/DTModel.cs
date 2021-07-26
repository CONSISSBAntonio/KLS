using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.DT
{
    public class DTModel
    {
        public List<DemandModel> aaData { get; set; }
        public int Draw { get; set; }
        public int ITotalRecords { get; set; }
        public int ITotalDisplayRecords { get; set; }
    }
}
