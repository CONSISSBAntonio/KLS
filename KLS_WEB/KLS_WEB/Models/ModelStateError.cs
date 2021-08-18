using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models
{
    public class ModelStateError
    {
        public Response Response { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
        public string ResetToken { get; set; }
    }
}
