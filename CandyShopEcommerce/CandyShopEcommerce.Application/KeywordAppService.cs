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
    public class KeywordAppService : IKeywordAppService
    {
        private readonly IKeywordService _iKeywordService;

        public KeywordAppService(IKeywordService iKeywordService)
        {
            _iKeywordService = iKeywordService;
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
            return _iKeywordService.KeywordsNotInProduct(entity);
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
