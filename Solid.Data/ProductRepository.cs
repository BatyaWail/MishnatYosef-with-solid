using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data
{
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Product product)
        {
            _dataContext.products.Add(product);
        }

        public Product GetById(int id)
        {
            return _dataContext.products.Find(x => x.Id == id);

        }

        public List<Product> GetList()
        {
            return _dataContext.products;
        }

        public void Remove(int id)
        {
            _dataContext.products.Remove(_dataContext.products.Find(x => x.Id == id));
        }

        public void Update(int id, Product product)
        {
            int x = _dataContext.products.FindIndex(x => x.Id == id);
            _dataContext.products[x] = product;
        }
    }
}
