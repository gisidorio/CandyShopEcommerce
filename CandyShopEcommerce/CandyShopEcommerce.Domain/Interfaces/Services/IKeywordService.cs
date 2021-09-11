using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface IKeywordService
    {
        List<Keyword> GetAll(Keyword entity);
        Keyword Get(Keyword entity);
        void Update(Keyword entity);
        int Save(Keyword entity);
        void Delete(Keyword entity);
        List<Keyword> KeywordsNotInProduct(Product entity);
    }
}
