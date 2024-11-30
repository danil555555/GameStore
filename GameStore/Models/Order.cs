namespace GameStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
