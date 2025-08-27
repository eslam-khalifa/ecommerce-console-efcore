using ECommerce.Data;

namespace ECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=DESKTOP-SOG9J7V;Database=ECommerceEFCoreDb;Trusted_Connection=True;TrustServerCertificate=True;").Options;
            using var context = new ApplicationDbContext(options);
            context.Database.Migrate();

            var queries = new EFCoreQueries(context);

            queries.ListCustomersWithOrdersCount();
            Console.WriteLine();
            queries.OrderDetails();
            Console.WriteLine();
            queries.GetProductsByCategory("Electronics");
        }
    }
}
