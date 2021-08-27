using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class CompanyProductRepository : RepositoryBase<CompanyProduct>, ICompanyProductRepository
    {
        public void Delete(CompanyProduct entity)
        {
            throw new NotImplementedException();
        }

        public CompanyProduct Get(CompanyProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<CompanyProduct> GetAll(CompanyProduct entity)
        {
            List<CompanyProduct> companyProducts = null;

            var parameters = new
            {
                entity.CompanyId
            };

            try
            {
                companyProducts = base.QueryList(Procedures.sp_select_company_product, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return companyProducts;
        }

        public int Save(CompanyProduct entity)
        {
            var Id = 0;

            var parameters = new
            {
                entity.CompanyId,
                entity.ProductId,
                entity.StockQuantity
            };

            try
            {
                Id = base.Save(Procedures.sp_insert_company_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return Id;
        }

        public void Update(CompanyProduct entity)
        {
            var parameters = new
            {
                entity.CompanyId,
                entity.ProductId,
                entity.StockQuantity
            };

            try
            {
                base.Update(Procedures.sp_update_company_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }
        }
    }
}
