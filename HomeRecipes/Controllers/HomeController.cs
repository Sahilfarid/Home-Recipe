using Microsoft.AspNetCore.Mvc;

namespace HomeRecipes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Recipe = "Our Famous House Made Recipe";
            ViewBag.dis = "Experience the joy of home-cooked meals with  Home Recipe, where every recipe is a blend of tradition and taste";
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
