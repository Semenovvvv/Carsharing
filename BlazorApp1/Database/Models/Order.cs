namespace BlazorApp1.Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalToPay { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
