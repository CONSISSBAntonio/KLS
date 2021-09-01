using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated{ get; set; }
    }
}
