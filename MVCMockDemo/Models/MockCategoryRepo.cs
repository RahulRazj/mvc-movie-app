namespace MVCMockDemo.Models
{
    public class MockCategoryRepo : ICategoryRepo
    {
        readonly List<Category> _categories;

        public MockCategoryRepo()
        {
            _categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Sci Fi", Description = "All Science Fiction"},
                new Category{CategoryId = 2, CategoryName = "Thriller", Description = "All Thriller & Action"},
                new Category{CategoryId = 3, CategoryName = "Drama", Description = "All Drama"},
            };
        }

        public IEnumerable<Category> AllCategories => _categories;
    }
}
