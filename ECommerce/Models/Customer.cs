﻿namespace ECommerce.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
