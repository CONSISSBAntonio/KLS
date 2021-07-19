using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLS_WEB.Models.Search;

namespace KLS_WEB.Controllers.Demand
{
    public class DemandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Search(Search search){
            return Json(search);
        }
    }
}
