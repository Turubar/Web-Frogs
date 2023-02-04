using Microsoft.AspNetCore.Mvc;

namespace WebFrogs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
