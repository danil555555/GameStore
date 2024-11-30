namespace GameStore.Models
{
    public class CartItems
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int PriceTypeId { get; set; }
    }
}
