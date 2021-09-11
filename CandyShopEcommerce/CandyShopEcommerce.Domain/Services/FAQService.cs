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
    public class FAQService : IFAQService
    {
        private readonly IFAQRepository _iFAQRepository;

        public FAQService(IFAQRepository iFAQRepository)
        {
            _iFAQRepository = iFAQRepository;
        }

        public void Delete(FAQ entity)
        {
            throw new NotImplementedException();
        }

        public FAQ Get(FAQ entity)
        {
            throw new NotImplementedException();
        }

        public List<FAQ> GetAll(FAQ entity)
        {
            throw new NotImplementedException();
        }

        public List<FAQ> GetAllByProductId(Product entity)
        {
            return _iFAQRepository.GetAllByProductId(entity);
        }

        public int Save(FAQ entity)
        {
            return _iFAQRepository.Save(entity);
        }

        public void Update(FAQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
