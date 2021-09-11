using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface IClientAppService
    {
        List<Client> GetAll(Client entity);
        Client Get(Client entity);
        void Update(Client entity);
        int Save(Client entity);
        void Delete(Client entity);
    }
}
