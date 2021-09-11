using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface IKeywordProductService
    {
        List<KeywordProduct> GetAll(KeywordProduct entity);
        CompanyProduct Get(KeywordProduct entity);
        void Update(KeywordProduct entity);
        int Save(KeywordProduct entity);
        void Delete(KeywordProduct entity);
        List<KeywordProduct> GetKeywordsByProduct(KeywordProduct entity);
    }
}
