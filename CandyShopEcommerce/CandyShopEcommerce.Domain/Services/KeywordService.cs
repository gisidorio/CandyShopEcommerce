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
    public class KeywordService : IKeywordService
    {
        private readonly IKeywordRepository _iKeywordRepository;

        public KeywordService(IKeywordRepository iKeywordRepository)
        {
            _iKeywordRepository = iKeywordRepository;                
        }

        public void Delete(Keyword entity)
        {
            throw new NotImplementedException();
        }

        public Keyword Get(Keyword entity)
        {
            throw new NotImplementedException();
        }

        public List<Keyword> GetAll(Keyword entity)
        {
            throw new NotImplementedException();
        }

        public List<Keyword> KeywordsNotInProduct(Product entity)
        {
            return _iKeywordRepository.KeywordsNotInProduct(entity);
        }

        public int Save(Keyword entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Keyword entity)
        {
            throw new NotImplementedException();
        }
    }
}
