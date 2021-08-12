using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class ruta_has_inventario
    {
        [Key]
        public int Id { get; set; }
        public int Id_Tr_Has_RutasId { get; set; }
        public int Id_Inventario { get; set; }
        public int Costo { get; set; }
    }
}