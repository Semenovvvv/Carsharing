using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Database
{
    public class DatabaseUtility
    {
        public static async Task EnsureDbCreatedAndSeedAsync(DbContextOptions<ApplicationDbContext> options)
        {
            // empty to avoid logging while inserting (otherwise will flood console)
            var factory = new LoggerFactory();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>(options)
                .UseLoggerFactory(factory);

            using var context = new ApplicationDbContext(builder.Options);
            // result is true if the database had to be created
            if (await context.Database.EnsureCreatedAsync())
            {
                var seed = new SeedData();
                await seed.InitializeAsync(context);
            }
        }
    }
}
