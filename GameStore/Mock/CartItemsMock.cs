using GameStore.Models;

namespace GameStore.Mock
{
    public class CartItemsMock
    {
        public List<CartItems> CartItemsItems { get; set; }
        public CartItemsMock(List<CartItems> CartItemsItems)
        {
            this.CartItemsItems = CartItemsItems;
        }
    }
}
