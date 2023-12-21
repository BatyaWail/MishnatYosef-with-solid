using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        void Update(int id, Product product);
        void Add(Product product);
        void Remove(int id);
    }
}
