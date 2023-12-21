using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IClientServices
    {
        List<Client> GetListItems();
        Client GetByIdItem(int id);
        void UpdateItem(int id, Client client);
        void AddItem(Client client);
        void RemoveItem(int id);
    }
}
