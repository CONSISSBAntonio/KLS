using System;
using System.ComponentModel.DataAnnotations;

namespace KLS_API.Models.Travel
{
    public class Substatus
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
