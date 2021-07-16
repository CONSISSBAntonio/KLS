using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Offer
{
    public class OfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
