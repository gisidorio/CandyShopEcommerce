using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class KeywordProductRepository : RepositoryBase<KeywordProduct>, IKeywordProductRepository
    {
        public void Delete(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public KeywordProduct Get(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<KeywordProduct> GetAll(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<KeywordProduct> GetKeywordsByProduct(KeywordProduct entity)
        {
            List<KeywordProduct> keywords = null;

            var parameters = new
            {
                entity.ProductId
            };

            try
            {
                keywords = base.QueryList(Procedures.sp_select_keyword_product, parameters);
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

        public int Save(KeywordProduct entity)
        {
            var KeywordId = 0;

            var parameters = new
            {
                entity.KeywordId,
                entity.ProductId
            };

            try
            {
                KeywordId = base.Save(Procedures.sp_insert_keyword_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return KeywordId;
        }

        public void Update(KeywordProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
