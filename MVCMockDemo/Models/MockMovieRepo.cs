namespace MVCMockDemo.Models
{
    public class MockMovieRepo : IMovieRepo
    {
        readonly List<Movie> _movieList;

        public MockMovieRepo()
        {
            _movieList = new List<Movie>
            {
                new Movie{Id = 1, Title = "Avatar", Cast = "Zoe Saldana", IsMovieOfTheWeek = true, Rating = 4.3f, CategoryId = 1, Price = 150},
                new Movie{Id = 2, Title = "Avatar 2", Cast = "Saldana", IsMovieOfTheWeek = true, Rating = 4.3f, CategoryId = 2, Price = 250},
                new Movie{Id = 3, Title = "The Godfather", Cast = "Al Pacino", IsMovieOfTheWeek = false, Rating = 4.2f, CategoryId = 1, Price = 185},
                new Movie{Id = 4, Title = "Notebook", Cast = "Scarlett", IsMovieOfTheWeek = true, Rating = 3.3f, CategoryId = 3, Price = 265},
                new Movie{Id = 5, Title = "12 Angry Men", Cast = "Henry", IsMovieOfTheWeek = false, Rating = 3.9f, CategoryId = 2, Price = 145},
                new Movie{Id = 6, Title = "Pulp Fiction", Cast = "Zoe Saldana", IsMovieOfTheWeek = false, Rating = 4.1f, CategoryId = 2, Price = 350},
                new Movie{Id = 7, Title = "Fight Club", Cast = "Eddie", IsMovieOfTheWeek = true, Rating = 4.0f, CategoryId = 1, Price = 245},
                new Movie{Id = 8, Title = "Forrest Gump", Cast = "Tom Hanks", IsMovieOfTheWeek = true, Rating = 4.9f, CategoryId = 3, Price = 175},
                new Movie{Id = 9, Title = "Inception", Cast = "Leonard", IsMovieOfTheWeek = false, Rating = 4.1f, CategoryId = 1, Price = 180},
                new Movie{Id = 10, Title = "Matrix", Cast = "Keanu", IsMovieOfTheWeek = true, Rating = 3.1f, CategoryId = 1, Price = 260},
                new Movie{Id = 11, Title = "The Fault in our Stars", Cast = "Zoe Saldana", IsMovieOfTheWeek = false, Rating = 2.9f, CategoryId = 3, Price = 150},
                new Movie{Id = 12, Title = "Se7en", Cast = "Brad ", IsMovieOfTheWeek = false, Rating = 3.7f, CategoryId = 2, Price = 150}

            };
        }
        public IEnumerable<Movie> AllMovies { get => _movieList; }
        public IEnumerable<Movie> MoviesOfTheWeek { get => _movieList; }

        public Movie ? GetMovieById(int id)
        {
            return AllMovies.FirstOrDefault(movie => movie.Id == id);
        }

        public void AddMovie(Movie movie) => _movieList.Add(movie);

        public void UpdateMovie(Movie movie)
        {
            var currentMovie = _movieList.FirstOrDefault(m => m.Id == movie.Id);
            if (currentMovie != null)
            {
                currentMovie.Title = movie.Title;
                currentMovie.Cast = movie.Cast;
                currentMovie.Rating = movie.Rating;
                currentMovie.Price = movie.Price;
                currentMovie.IsMovieOfTheWeek = movie.IsMovieOfTheWeek;
                currentMovie.CategoryId = movie.CategoryId;
            }
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
