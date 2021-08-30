using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KLS_API.Models.Travel
{
    public class Status
    {
        public int Id { get; set; }
        public ICollection<Substatus> Substatuses { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
