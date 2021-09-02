using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels.DTO
{
    public class SearchRuta
    {
        public int Id { get; set; }
        public string OD { get; set; }
        public int? OriginId { get; set; }
        public int? DestinationId { get; set; }
    }
}
