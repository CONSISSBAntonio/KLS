﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Travel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SubstatusId { get; set; }
        public Substatus Substatus { get; set; }
        public string Folio { get; set; }
        public int Cat_Tipos_UnidadesId { get; set; }
        public Cat_Tipos_Unidades Cat_Tipos_Unidades { get; set; }
        public ICollection<Section> Sections { get; set; } = new Collection<Section>();
        public string Ejecutivo { get; set; }
        public string GrupoMonitor { get; set; }
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
