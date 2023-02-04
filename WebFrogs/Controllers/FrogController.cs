using Microsoft.AspNetCore.Mvc;
using WebFrogs.Models;

namespace WebFrogs.Controllers
{
    public class FrogController : Controller
    {
        public IActionResult Page()
        {
            return View(Logic.GetFrog());
        }

        [Route("Frog/Frog/{id?}")]
        public IActionResult Frog(int id)
        {
            return View(Logic.GetFrog(id));
        }
    }
}
