using GameStore.Models;

namespace GameStore.Mock
{
    public class OrderStatusMock
    {
        public List<OrderStatus> OrderStatusItems { get; set; }
        public OrderStatusMock(List<OrderStatus> OrederStatusItems)
        {
            this.OrderStatusItems = OrederStatusItems;
        }
    }
}
