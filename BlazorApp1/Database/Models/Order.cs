using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalToPay { get; set; }
        public decimal TotalToPayWithDiscount {  get; set; }
        public TimeSpan WorkTime { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
