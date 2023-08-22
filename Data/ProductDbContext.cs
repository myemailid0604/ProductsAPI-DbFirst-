using Microsoft.EntityFrameworkCore;
using ProductsAPI_DbFirst_.Models;

namespace ProductsAPI_DbFirst_.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }



    }
}
