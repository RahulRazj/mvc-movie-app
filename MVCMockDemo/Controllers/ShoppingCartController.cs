using Microsoft.AspNetCore.Mvc;
using MVCMockDemo.Models;
using MVCMockDemo.ViewModels;

namespace MVCMockDemo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMovieRepo _movieRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMovieRepo movieRepo, ShoppingCart shoppingCart)
        {
            _movieRepo = movieRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int movieId)
        {
            var selectedMovie = _movieRepo.AllMovies.FirstOrDefault(movie => movie.Id == movieId);
            if (selectedMovie != null)
            {
                _shoppingCart.AddToCart(selectedMovie);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int movieId)
        {
            _shoppingCart.RemoveFromShoppingCart(movieId);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearShoppingCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }

}
