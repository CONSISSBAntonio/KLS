using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLS_WEB.Utility
{
    public class Resource
    {
        public Resource(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public const string APIBaseUrl = "https://localhost:44345/";
        //public const string APIBaseUrl = Encoding.UTF8.GetBytes(Configuration["JWT:key"]);
        public const string RegisterAPIUrl = APIBaseUrl + "Users/register";
        public const string LoginAPIUrl = APIBaseUrl + "Users/Login";
        public const string ContentType = "application/json";
    }
}
