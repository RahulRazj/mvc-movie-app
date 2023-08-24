using Microsoft.AspNetCore.Mvc;

namespace MVCMockDemo.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
