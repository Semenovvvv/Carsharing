using BlazorApp1.Database.Models;

namespace BlazorApp1.Database
{
    public class SeedData
    {
        public async Task InitializeAsync(ApplicationDbContext context)
        {
            var clients = new List<Client> {
                new Client { Id = 1, FirstName = "Иванов", LastName = "Иван", Patronymic = "Иванович", BonusDiscount = 0.05m },
                new Client { Id = 2, FirstName = "Петров", LastName = "Петр", Patronymic = "Петрович", BonusDiscount = 0.03m },
                new Client { Id = 3, FirstName = "Сергеев", LastName = "Владимир", Patronymic = "Геннадьевич", BonusDiscount = 0.02m },
                new Client { Id = 4, FirstName = "Васильев", LastName = "Федор", Patronymic = "Дмитриевич", BonusDiscount = 0.08m },
                new Client { Id = 5, FirstName = "Кириллов", LastName = "Шамиль", Patronymic = "Александрович", BonusDiscount = 0.04m }
            };

            await context.AddRangeAsync(clients);

            var cars = new List<Car>
            {
               new Car { Id = 1, Brand = "Lada", Model = "Vesta", PricePerMinute = 10m },
               new Car { Id = 2, Brand = "Lada", Model = "Granta", PricePerMinute = 8m },
               new Car { Id = 3, Brand = "Lada", Model = "Xray", PricePerMinute = 9m },
               new Car { Id = 4, Brand = "Renault", Model = "Logan", PricePerMinute = 13m },
               new Car { Id = 5, Brand = "Mazda", Model = "CX-5", PricePerMinute = 25m },
               new Car { Id = 6, Brand = "Kia", Model = "Rio", PricePerMinute = 17m },
               new Car { Id = 7, Brand = "Hyundai", Model = "Porter", PricePerMinute = 14m },
               new Car { Id = 8, Brand = "Hyundai", Model = "Solaris", PricePerMinute = 18m },
               new Car { Id = 9, Brand = "Hyundai", Model = "Santa Fe", PricePerMinute = 32m }
            };

            await context.AddRangeAsync(cars);

            await context.SaveChangesAsync();
        }
    }
}
