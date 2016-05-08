using System.Collections.Generic;
using System.Linq;
using Products.DAL.Interfaces;
using Products.DAL.Model;

namespace Products.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            using (var context = new ProductDbContext())
            {
                return context.Products.ToList();                
            }
        }

        public List<Product> Create(Product product)
        {
            using (var context = new ProductDbContext())
            {
                context.Products.Add(product);

                context.SaveChanges();

                return context.Products.ToList();
            }
        }

        public Product Delete(int id)
        {
            using (var context = new ProductDbContext())
            {
                Product product = context.Products.Find(id);
                return product;
            }
        }

        public List<Product> DeleteConfirmed(int id)
        {
            using (var context = new ProductDbContext())
            {
                Product product = context.Products.Find(id);

                context.Products.Remove(product);

                context.SaveChanges();

                return context.Products.ToList();
            }
        }
    }
}
