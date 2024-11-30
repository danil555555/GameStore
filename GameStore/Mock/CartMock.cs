using GameStore.Models;

namespace GameStore.Mock
{
    public class CartMock
    {
        public List<Cart> CartItems { get; set; }
        public CartMock(List<Cart> CartItems)
        {
            this.CartItems = CartItems;
        }
    }
}
