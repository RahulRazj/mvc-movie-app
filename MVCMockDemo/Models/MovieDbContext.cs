using Microsoft.EntityFrameworkCore;
namespace MVCMockDemo.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding the db
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 1,
                        CategoryName = "Action",
                        Description = "Tune in to Action peak movies",
                    }
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 2,
                        CategoryName = "Drama",
                        Description = "Tune in to Action peak movies",
                    }
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 3,
                        CategoryName = "Thriller",
                        Description = "Tune in to Action peak movies",
                    }
                );

            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 1,
                        Title = "Avengers",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 2,
                        Title = "12 Angry Men",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 3,
                        Title = "Pulp Fiction",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = false,
                        CategoryId = 1,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 4,
                        Title = "Fight Club",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 5,
                        Title = "Avengers",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 6,
                        Title = "Avengers",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 1,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 7,
                        Title = "The Godfather",
                        Cast = "Robert",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = false,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 8,
                        Title = "Inception",
                        Cast = "Leo",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 3,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 9,
                        Title = "Spiderverse",
                        Cast = "Miles",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 2,
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 10,
                        Title = "Endgame",
                        Cast = "Chris",
                        Price = 599,
                        Rating = 4.8f,
                        IsMovieOfTheWeek = true,
                        CategoryId = 3,
                    }
                );
        }
    }
}
