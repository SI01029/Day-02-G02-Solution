using Microsoft.AspNetCore.Mvc;

namespace Day_02_G02.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

    }
}
