using ECommerce.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configurations
{
    internal class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FullName).IsRequired(true).HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired(true);
            builder.HasData(
                new Customer { Id = 1, FullName = "John Doe", Email = "john@gmail.com" },
                new Customer { Id = 2, FullName = "Alice Smith", Email = "alice@gmail.com"}
            );
        }
    }
}
