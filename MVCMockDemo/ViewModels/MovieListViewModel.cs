using MVCMockDemo.Models;

namespace MVCMockDemo.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public string CurrentCategory { get; set; }
        public MovieListViewModel(IEnumerable<Movie> movie, string? currentCategory)
        {
            Movies = movie;
            CurrentCategory = currentCategory;
        }
    }
}
