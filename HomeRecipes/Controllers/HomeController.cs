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
            TempData["mess"] = "welcome services page this text fetch from another object using Tempdata";
            TempData.Keep();
            return View();
        }
        public IActionResult services()
        {
            ViewData["ch"] = "welcome to the Services";
            return View();
        }
    }
}
