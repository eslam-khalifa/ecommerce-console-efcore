using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configurations
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired(true).HasMaxLength(100);
            builder.Property(p => p.Price).HasColumnType("decimal(10, 2)");
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            builder.HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200, CategoryId = 1 },
                new Product { Id = 2, Name = "Headphones", Price = 150, CategoryId = 1 },
                new Product { Id = 3, Name = "C# in depth", Price = 40, CategoryId = 2}
             );
        }
    }
}
