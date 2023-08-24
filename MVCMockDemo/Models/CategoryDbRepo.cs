namespace MVCMockDemo.Models
{
    public class CategoryDbRepo : ICategoryRepo
    {
        private readonly MovieDbContext _movieDbContext;

        public CategoryDbRepo(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public IEnumerable<Category> AllCategories => _movieDbContext.Categories;
    }
}
