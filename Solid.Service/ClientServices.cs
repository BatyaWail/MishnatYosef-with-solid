using Microsoft.AspNetCore.Mvc;
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
    internal class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddItem(Client client)
        {
            _clientRepository.Add(client);
        }

        public Client GetByIdItem(int id)
        {
            return _clientRepository.GetById(id);
            //return OkObjectResult(_clientRepository.GetById(id));
        }

        public List<Client> GetListItems()
        {
            return _clientRepository.GetList();
        }

        public void RemoveItem(int id)
        {
            _clientRepository.Remove(id);
        }

        public void UpdateItem(int id, Client client)
        {
            _clientRepository.Update(id, client);
        }
    }
}
