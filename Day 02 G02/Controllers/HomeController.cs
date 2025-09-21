using Microsoft.AspNetCore.Mvc;

namespace Day_02_G02.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //Get: base url/Home/index
        //view : HTML Page
        //Razor Page :HTML + C#
        public IActionResult Index()
        {
            return View();
            // return View("Home");
            //return View("Movie");

        }
        [HttpGet] //Get: base url/Home/AboutUs
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet] //Get: base url/Home/ContactUs
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpGet] //Get: base url/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }
    
}

}
