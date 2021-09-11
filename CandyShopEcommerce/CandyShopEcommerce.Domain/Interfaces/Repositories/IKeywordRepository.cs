using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Repositories
{
    public interface IKeywordRepository : IRepositoryBase<Keyword>
    {
        List<Keyword> KeywordsNotInProduct(Product entity);
    }
}
