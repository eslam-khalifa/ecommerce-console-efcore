using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configurations
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("order");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerId);
            builder.HasData(
                new Order { Id = 1, OrderDate = new DateTime(2025, 8, 27, 12, 34, 56, DateTimeKind.Utc), CustomerId = 1 },
                new Order { Id = 2, OrderDate = new DateTime(2025, 8, 28, 9, 0, 0, DateTimeKind.Utc), CustomerId = 2 }
            );
        }
    }
}
