using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    internal class ProductService : IProductServices
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddItem(Product product)
        {
            _productRepository.Add(product);
        }

        public Product GetByIdItem(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetListItems()
        {
            return _productRepository.GetList();
        }

        public void RemoveItem(int id)
        {
            _productRepository.Remove(id);
        }

        public void UpdateItem(int id, Product product)
        {
            _productRepository.Update(id, product);
        }
    }
}
