namespace MVCMockDemo.Models
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
