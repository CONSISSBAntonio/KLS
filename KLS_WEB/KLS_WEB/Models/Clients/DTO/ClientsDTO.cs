using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients.DTO
{
    public class ClientsDTO
    {
        //public Clientes Clientes { get; set; } = new Clientes();
        public InitSelects Selects { get; set; } = new InitSelects();
        public class InitSelects
        {
            public List<SelectListItem> Clientes { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> Status { get; set; } = new List<SelectListItem>();
            public List<SelectListItem> SubStatus { get; set; } = new List<SelectListItem>();
            public Monitoring.Monitor_ monitoreo { get; set; } = new Monitoring.Monitor_();
        }
    }
}
