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
    public class FAQAppService : IFAQAppService
    {
        private readonly IFAQService _iFAQService;

        public FAQAppService(IFAQService iFAQService)
        {
            _iFAQService = iFAQService;
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
            return _iFAQService.GetAllByProductId(entity);
        }

        public int Save(FAQ entity)
        {
            return _iFAQService.Save(entity);
        }

        public void Update(FAQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
