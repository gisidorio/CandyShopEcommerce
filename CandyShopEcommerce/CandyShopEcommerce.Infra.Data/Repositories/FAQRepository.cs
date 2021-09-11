using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class FAQRepository : RepositoryBase<FAQ>, IFAQRepository
    {
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
            List<FAQ> faqs = null;

            var parameters = new
            {
                entity.Id
            };

            try
            {
                faqs = base.QueryList(Procedures.sp_select_faq_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return faqs;
        }

        public int Save(FAQ entity)
        {
            var FAQId = 0;

            var parameters = new
            {
                entity.Question,
                entity.Answer,
                entity.ProductId
            };

            try
            {
                FAQId = base.Save(Procedures.sp_insert_faq, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return FAQId;
        }

        public void Update(FAQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
