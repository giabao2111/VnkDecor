using Microsoft.AspNetCore.Mvc;

namespace VnkDecor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View("Detail");
        }

    }
}
