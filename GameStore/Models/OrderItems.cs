namespace GameStore.Models
{
    public class OrderItems
    { 
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
