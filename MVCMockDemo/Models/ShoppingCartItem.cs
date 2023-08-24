namespace MVCMockDemo.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Movie Movie { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
