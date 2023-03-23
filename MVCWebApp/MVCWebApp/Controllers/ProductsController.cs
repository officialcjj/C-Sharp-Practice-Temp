using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
