namespace BlazorApp1.Database.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand {  get; set; }
        public string Model { get; set; }
        public TimeSpan WorkTime { get; set; }
        public decimal Cost { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
