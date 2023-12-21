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
            return _dataContext.products.ToList().Find(x => x.Id == id);

        }

        public List<Product> GetList()
        {
            return _dataContext.products.ToList();
        }

        public void Remove(int id)
        {
            _dataContext.products.Remove(_dataContext.products.ToList().Find(x => x.Id == id));
        }

        public void Update(int id, Product product)
        {
            int x = _dataContext.products.ToList().FindIndex(x => x.Id == id);
            _dataContext.products.ToList()[x] = product;
        }
    }
}
