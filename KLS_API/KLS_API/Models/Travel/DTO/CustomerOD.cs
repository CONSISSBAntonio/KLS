using KLS_API.Models.Clients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel.DTO
{
    public class CustomerOD
    {
        public ICollection<Cl_Has_Origen> Origins { get; set; } = new Collection<Cl_Has_Origen>();
        public ICollection<Cl_Has_Destinos> Destinations { get; set; } = new Collection<Cl_Has_Destinos>();
    }
}
