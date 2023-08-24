using Microsoft.AspNetCore.Mvc;
using MVCMockDemo.Models;

namespace MVCMockDemo.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryMenu(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepo.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
