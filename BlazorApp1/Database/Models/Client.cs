using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Database.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public decimal BonusDiscount { get; set; }
    }
}
