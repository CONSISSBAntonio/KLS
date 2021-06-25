using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Carriers.CarriersOperators
{
    public class OperatorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
