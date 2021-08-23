using Microsoft.AspNetCore.Mvc;

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
