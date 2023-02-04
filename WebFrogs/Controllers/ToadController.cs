using Microsoft.AspNetCore.Mvc;
using WebFrogs.Models;

namespace WebFrogs.Controllers
{
    public class ToadController : Controller
    {
        public IActionResult Page()
        {
            return View(Logic.GetToad());
        }

        public IActionResult Toad(int id)
        {
            return View(Logic.GetToad(id));
        }
    }
}
