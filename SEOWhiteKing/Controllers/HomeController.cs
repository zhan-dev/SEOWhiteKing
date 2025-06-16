using Microsoft.AspNetCore.Mvc;

namespace SEOWhiteKing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}