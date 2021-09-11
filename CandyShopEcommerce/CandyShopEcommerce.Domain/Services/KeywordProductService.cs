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
    public class KeywordProductService : IKeywordProductService
    {
        private readonly IKeywordProductRepository _iKeywordProductRepository;

        public KeywordProductService(IKeywordProductRepository iKeywordProductRepository)
        {
            _iKeywordProductRepository = iKeywordProductRepository;
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
            return _iKeywordProductRepository.GetKeywordsByProduct(entity);
        }

        public int Save(KeywordProduct entity)
        {
            return _iKeywordProductRepository.Save(entity);
        }

        public void Update(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
