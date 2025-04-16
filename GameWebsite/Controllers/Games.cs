using Microsoft.AspNetCore.Mvc;

namespace GameWebsite.Controllers
{
    public class Games : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create ()
        {
            return View();
        }

    }
}
