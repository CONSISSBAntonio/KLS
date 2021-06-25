using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Catalogs.Customers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
