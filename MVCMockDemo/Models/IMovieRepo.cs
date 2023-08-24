namespace MVCMockDemo.Models
{
    public interface IMovieRepo
    {
        public IEnumerable<Movie> AllMovies { get; }
        public IEnumerable<Movie> MoviesOfTheWeek { get; }
        Movie? GetMovieById(int id);

        public void UpdateMovie(Movie movie);

        public void AddMovie(Movie movie);

        public void DeleteMovie(int id);
    }
}
