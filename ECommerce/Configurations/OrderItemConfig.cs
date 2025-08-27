using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configurations
{
    internal class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(oi => new {oi.OrderId, oi.ProductId});
            builder.Property(oi => oi.Quantity).IsRequired(true);
            builder.Property(oi => oi.UnitPrice).HasColumnType("decimal(10, 2)");
            builder.HasOne(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderId);
            builder.HasOne(oi => oi.Product).WithMany(p => p.OrderItems).HasForeignKey(oi => oi.ProductId);
            builder.HasData(
                new OrderItem { OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 1200 },
                new OrderItem { OrderId = 1, ProductId = 2, Quantity = 2, UnitPrice = 150 },
                new OrderItem { OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 40 }
            );
        }
    }
}
