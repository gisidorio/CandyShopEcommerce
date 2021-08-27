using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Product entity)
        {
            List<Product> products = null;

            var parameters = new
            {
                entity.CompanyId
            };

            try
            {
                products = base.QueryList(Procedures.sp_select_product, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return products;
        }

        public int Save(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
