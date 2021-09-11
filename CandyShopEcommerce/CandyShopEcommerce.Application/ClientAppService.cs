using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application
{
    public class ClientAppService : IClientAppService
    {
        private readonly IClientService _iClientService;

        public ClientAppService(IClientService iClientService)
        {
            _iClientService = iClientService;
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
            return _iClientService.Save(entity);
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
