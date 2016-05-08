using Products.DAL.Model;
using System.Collections.Generic;


namespace Products.DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        List<Product> Create(Product product);

        Product Delete(int id);

        List<Product> DeleteConfirmed(int id);
    }
}
