using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _iClientRepository;

        public ClientService(IClientRepository iClientRepository)
        {
            _iClientRepository = iClientRepository;
        }

        public void Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public Client Get(Client entity)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll(Client entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Client entity)
        {
            return _iClientRepository.Save(entity);
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
