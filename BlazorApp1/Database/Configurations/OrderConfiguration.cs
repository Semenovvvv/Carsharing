using BlazorApp1.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Database.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.Client)
                .WithMany()
                .HasForeignKey(o => o.ClientId);

            builder.HasOne(o => o.Car)
               .WithMany()
               .HasForeignKey(o => o.CarId);

            builder.Navigation(x => x.Car)
                .AutoInclude();

            builder.Navigation(x => x.Client)
                .AutoInclude();
        }
    }
}
