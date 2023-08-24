using System.ComponentModel;

namespace MVCMockDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cast { get; set; }
        public decimal Price { get; set; }
        public float Rating { get; set; }
        public bool IsMovieOfTheWeek { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
