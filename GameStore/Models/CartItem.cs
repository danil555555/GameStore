namespace GameStore.Models
{
    public class CartItem
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int PriceTypeId { get; set; }
    }
}
