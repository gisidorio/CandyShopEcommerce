using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class KeywordRepository : RepositoryBase<Keyword>, IKeywordRepository
    {
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
            List<Keyword> keywords = null;

            var parameters = new
            {
                entity.Id
            };

            try
            {
                keywords = base.QueryList(Procedures.sp_select_keyword_not_in_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return keywords;
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
