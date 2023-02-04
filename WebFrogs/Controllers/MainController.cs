using Microsoft.AspNetCore.Mvc;

namespace WebFrogs.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
