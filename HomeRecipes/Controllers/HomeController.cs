using Microsoft.AspNetCore.Mvc;

namespace HomeRecipes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Recipe = "Our Famous House Made Recipe";
            return View();
        }

        public IActionResult about()
        {
            return View();
        }
        public IActionResult services()
        {
            return View();
        }
    }
}
