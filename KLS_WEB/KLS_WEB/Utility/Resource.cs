﻿using System;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace KLS_WEB.Utility
{
    public class Resource
    {
        public const string APIBaseUrl = "https://localhost:44345/";
        //public const string APIBaseUrl = "http://localhost:3002/KLSAPIPROD/";
        //public const string APIBaseUrl = "http://3.227.133.22:3001/KLSAPI/";
        public const string RegisterAPIUrl = APIBaseUrl + "Users/register";
        public const string LoginAPIUrl = APIBaseUrl + "Users/Login";
        public const string RecoveryAPIUrl = APIBaseUrl + "Users/Recovery";
        public const string ContentType = "application/json";
    }
}
