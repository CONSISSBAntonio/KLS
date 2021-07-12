using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.DTO
{
    public class UserTokenDTO
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
    }
}
