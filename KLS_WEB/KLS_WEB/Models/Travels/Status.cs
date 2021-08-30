﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Status
    {
        public int Id { get; set; }
        public ICollection<Substatus> Substatuses { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
