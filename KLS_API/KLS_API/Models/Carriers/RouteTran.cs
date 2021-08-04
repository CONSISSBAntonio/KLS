using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Carriers
{
    public class RouteTran
    {
        public int id_estadoorigen { get; set; }
        public int id_ciudadorigen { get; set; }
        public int id_estadodestino { get; set; }
        public int id_ciudaddestino { get; set; }
    }
}
