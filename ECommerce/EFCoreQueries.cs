using ECommerce.Data;

namespace ECommerce
{
    internal class EFCoreQueries (ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public void ListCustomersWithOrdersCount()
        {
            var customersWithOrdersCount = _context.Customers.Include(c => c.Orders).ToList();
            foreach(var customerWithOrdersCount in customersWithOrdersCount)
            {
                Console.WriteLine($"{customerWithOrdersCount.Id} {customerWithOrdersCount.Email}, {customerWithOrdersCount.FullName}, {customerWithOrdersCount.Orders?.Count}");
            }
        }

        public void OrderDetails()
        {
            var orderDetails = _context.OrderItems.Include(oi => oi.Product).Include(oi => oi.Order).ThenInclude(oi => oi.Customer).ToList();
            var orderDetailsSelected = orderDetails.Select(oi => new {
                CustomerFullName = oi.Order?.Customer?.FullName ?? "Unknown",
                ProductName = oi.Product?.Name ?? "Unknown",
                Quantity = oi.Quantity,
                Price = oi.UnitPrice,
                Total = oi.Quantity * oi.UnitPrice
            }).ToList();
            foreach(var orderDetail in orderDetailsSelected)
            {
                Console.WriteLine($"{orderDetail.CustomerFullName} bought {orderDetail.Quantity} x {orderDetail.ProductName} @ {orderDetail.Price} = {orderDetail.Total}");
            }
        }

        public void GetProductsByCategory(string CategoryName)
        {
            var productsWithCategory = _context.Products.Include(p => p.Category).ToList();
            var products = from p in productsWithCategory
                           where p.Category?.Name == CategoryName
                           select new {
                               p.Name,
                               p.Price,
                               CategoryName = p.Category?.Name ?? "Unknown"
                           };
            foreach (var p  in products)
            {
                Console.WriteLine($"{p.Name} ({p.CategoryName}) - {p.Price:C}");
            }
        }
    }
}
