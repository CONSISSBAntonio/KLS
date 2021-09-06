﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class SectionComment
    {
        public int Id { get; set; }
        [Required]
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
        [Required]
        public int SubstatusId { get; set; }
        public virtual Substatus Substatus { get; set; }
        [Required]
        public string Comment { get; set; }
        public virtual ICollection<Evidence> Evidences { get; set; }
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; } = DateTime.Now;
    }
}
