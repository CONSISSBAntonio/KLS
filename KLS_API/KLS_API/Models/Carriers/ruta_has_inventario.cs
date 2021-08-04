using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Carriers
{
    public class ruta_has_inventario
    {
        [Key]
        public int Id { get; set; }
        public int Id_Tr_Has_Rutas { get; set; }
        public int Id_Inventario { get; set; }  
    }
}
