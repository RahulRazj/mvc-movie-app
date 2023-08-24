using Microsoft.AspNetCore.Mvc;

namespace MVCMockDemo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
