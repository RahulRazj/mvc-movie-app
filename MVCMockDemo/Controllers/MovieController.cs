using Microsoft.AspNetCore.Mvc;
using MVCMockDemo.Models;

namespace MVCMockDemo.Controllers
{
    //[Route("emovies/[controller]/[action]")]
    public class MovieController : Controller
    {
        private readonly IMovieRepo _movieRepo;
        private readonly ICategoryRepo _categoryRepo;

        public MovieController(IMovieRepo movieRepo, ICategoryRepo categoryRepo)
        {
            _movieRepo = movieRepo;
            _categoryRepo = categoryRepo;
        }


        //[Route("")]
        //[Route("Movie/Index")]
        //[Route("Movie/Index/{id}")]
        public ActionResult Index(int category, string searchQuery)
        {

            IEnumerable<Movie> movies = _movieRepo.AllMovies.OrderBy(movie => movie.Title);

            if (!String.IsNullOrEmpty(searchQuery))
            {
                movies = movies.Where(movie => movie.Title.ToLower().Contains(searchQuery.ToLower()));
            }

            if (category != 0)
            {
                movies = movies.Where(movie => movie.CategoryId == category);
            }
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            var movie = _movieRepo.GetMovieById(id);
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Movie movie)
        {
            _movieRepo.UpdateMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {

            _movieRepo.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var movie = _movieRepo.GetMovieById(id);
            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            var movie = _movieRepo.GetMovieById(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            movie.IsDeleted = true;
            _movieRepo.DeleteMovie(movie.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
