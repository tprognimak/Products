using System.Data.Entity;

namespace Products.DAL.Model
{
    public class ProductDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
