using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }
    }
}
