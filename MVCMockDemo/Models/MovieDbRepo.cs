using Microsoft.EntityFrameworkCore;

namespace MVCMockDemo.Models
{
    public class MovieDbRepo : IMovieRepo
    {
        private readonly MovieDbContext _movieDbContext;

        public MovieDbRepo(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public IEnumerable<Movie> AllMovies => _movieDbContext.Movies.Where(movie => !movie.IsDeleted).Include(c => c.Category);

        public IEnumerable<Movie> MoviesOfTheWeek => AllMovies.Where(movie => movie.IsMovieOfTheWeek);

        public void AddMovie(Movie movie)
        {
            _movieDbContext.Add(movie);
            _movieDbContext.SaveChanges();
        }

        public Movie? GetMovieById(int id)
        {
            return AllMovies.FirstOrDefault(movie => movie.Id == id);
        }

        public void UpdateMovie(Movie movie)
        {
            _movieDbContext.Update(movie);
            _movieDbContext.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var movie = GetMovieById(id);
            if(movie != null)
            {
                movie.IsDeleted = true;
                UpdateMovie(movie);
            }

        }
    }
}
