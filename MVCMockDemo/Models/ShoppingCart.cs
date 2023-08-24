using Microsoft.EntityFrameworkCore;

namespace MVCMockDemo.Models
{
    public class ShoppingCart
    {

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public decimal TotalCartAmount { get; set; }

        private readonly MovieDbContext _movieDbContext;
        public ShoppingCart(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        // Get Cart / Add To Cart / Remove Cart / Get Shopping items / Clear Cart / Total

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            var context = services.GetService<MovieDbContext>();
            string cartId = session.GetString("cartId");
            if (cartId == null)
            {
                cartId = Guid.NewGuid().ToString();
                session.SetString("cartId", cartId);
            }
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Movie movie)
        {
            var shoppingCartItem = _movieDbContext.ShoppingCartItems.SingleOrDefault(s => s.Movie.Id == movie.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new()
                {
                    Movie = movie,
                    ShoppingCartId = ShoppingCartId,
                    Quantity = 1
                };
                _movieDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }

            _movieDbContext.SaveChanges();
        }

        public void RemoveFromShoppingCart(int movieId)
        {
            var shoppingCartItem = _movieDbContext.ShoppingCartItems.SingleOrDefault(s => s.Movie.Id == movieId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem != null && shoppingCartItem.Quantity > 0)
            {
                shoppingCartItem.Quantity--;
                _movieDbContext.SaveChanges();
            }
        }

        public void ClearCart()
        {
            _movieDbContext.ShoppingCartItems.RemoveRange(_movieDbContext.ShoppingCartItems);
            _movieDbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _movieDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Movie).ToList();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _movieDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Movie.Price * c.Quantity).Sum();
            return total;
        }
    }
}
