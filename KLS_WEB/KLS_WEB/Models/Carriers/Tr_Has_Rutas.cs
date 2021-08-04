using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Carriers
{
    public class Tr_Has_Rutas
    {
        [Key]
        public int Id { get; set; }
        public int Id_Ruta { get; set; }
        public int Id_Transportista { get; set; }

        [Column(TypeName = "decimal(14,2)")]
        public decimal Costo { get; set; }
        public int Estatus { get; set; }
        public List<ruta_has_inventario> ruta_has_inventario { get; set; }
    }
}
