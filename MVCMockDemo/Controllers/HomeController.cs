using Microsoft.AspNetCore.Mvc;
using MVCMockDemo.Models;
using System.Diagnostics;

namespace MVCMockDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieRepo _movieRepo;

        public HomeController(ILogger<HomeController> logger, IMovieRepo movieRepo)
        {
            _logger = logger;
            _movieRepo = movieRepo;
        }

        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _movieRepo.AllMovies.Where(movie => movie.IsMovieOfTheWeek);
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}