using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Checkpoint
    {
        [Key]
        public int Id {get;set;}
        [Column(TypeName = "varchar(30)")]
        public string Checkpoint {get;set;}
        public int Id_Ruta {get;set;} //Conversion
        public int Tiempo {get;set;}
        public int Estatus {get;set;}
    }
}
