using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetList();
        Client GetById(int id);
        void Update(int id, Client client);
        void Add(Client client);
        void Remove(int id);
    }
}
