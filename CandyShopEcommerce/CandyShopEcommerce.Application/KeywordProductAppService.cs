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
    public class KeywordProductAppService : IKeywordProductAppService
    {
        private readonly IKeywordProductService _iKeywordProductService;

        public KeywordProductAppService(IKeywordProductService iKeywordProductService)
        {
            _iKeywordProductService = iKeywordProductService;
        }

        public void Delete(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public CompanyProduct Get(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<KeywordProduct> GetAll(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<KeywordProduct> GetKeywordsByProduct(KeywordProduct entity)
        {
            return _iKeywordProductService.GetKeywordsByProduct(entity);
        }

        public int Save(KeywordProduct entity)
        {
            return _iKeywordProductService.Save(entity);
        }

        public void Update(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
