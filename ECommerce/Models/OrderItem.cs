namespace ECommerce.Models
{
    internal class OrderItem
    {
        public Order? Order { get; set; }
        public int OrderId { get; set; }

        public Product? Product { get; set; }
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of this product included in this order.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The price of a single unit of the product at the time the order was placed.
        /// This value is stored separately from <see cref="Product.Price"/> to keep the price of the product at this time because the price of the product may change after the order is created.
        /// </summary>
        public decimal? UnitPrice { get; set; }
    }
}
