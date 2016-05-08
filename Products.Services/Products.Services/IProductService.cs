using Products.DAL.Model;
using System.Collections.Generic;

namespace Products.Services
{
     public interface IProductService
    {
        List<Product> GetProducts();

        List<Product> Create(Product product);

        Product Delete(int id);

        List<Product> DeleteConfirmed(int id);
    }
}
