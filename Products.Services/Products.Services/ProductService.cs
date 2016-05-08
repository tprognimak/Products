using Products.DAL.Interfaces;
using Products.DAL.Model;
using Products.DAL.Repositories;
using System.Collections.Generic;

namespace Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public List<Product> Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public Product Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public List<Product> DeleteConfirmed(int id)
        {
            return _productRepository.DeleteConfirmed(id);
        }
    }
}
