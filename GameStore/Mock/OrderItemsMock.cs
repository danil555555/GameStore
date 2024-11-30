using GameStore.Models;

namespace GameStore.Mock
{
    public class OrderItemsMock
    {
        public List<OrderItems> OrderItemsItems { get; set; }
        public OrderItemsMock(List<OrderItems> OrderItemsItems)
        {
            this.OrderItemsItems = OrderItemsItems;
        }
    }
}

