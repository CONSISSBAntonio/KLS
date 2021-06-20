using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Utility
{
    public class Resource
    {
        public const string APIBaseUrl = "https://localhost:44345/";
        //public const string APIBaseUrl = "http://localhost:8080/KLS_API/";
        public const string RegisterAPIUrl = APIBaseUrl + "Users/register";
        public const string LoginAPIUrl = APIBaseUrl + "Users/Login";
        public const string ContentType = "application/json";
    }
}
