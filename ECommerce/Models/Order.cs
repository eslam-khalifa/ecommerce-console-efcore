using Microsoft.VisualBasic;

namespace ECommerce.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = default;

        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
