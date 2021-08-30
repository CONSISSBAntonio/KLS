using KLS_WEB.Models.Carriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Travels
{
    public class Unit
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int Cat_Tipos_UnidadesId { get; set; }
        public Cat_Tipos_Unidades Cat_Tipos_Unidades { get; set; }
        public int Tr_Has_InventarioId { get; set; }
        public Tr_Has_Inventario Tr_Has_Inventario { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
