using GameStore.Models;

namespace GameStore.Mock
{
    public class OrderMock
    {
        public List<Order> OrderItems { get; set; }
        public OrderMock(List<Order> OrderItems)
        {
            this.OrderItems = OrderItems;
        }
    }
}
