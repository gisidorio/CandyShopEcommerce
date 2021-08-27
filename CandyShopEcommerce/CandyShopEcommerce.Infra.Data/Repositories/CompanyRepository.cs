using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository 
    {
        public void Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public Company Get(Company entity)
        {
            Company company = null;

            var parameters = new
            {
                entity.Id
            };

            try
            {
                company = base.Query(Procedures.sp_select_company, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Dispose();
            }

            return company;
        }

        public List<Company> GetAll(Company entity)
        {
            List<Company> companies = null;

            var parameters = new
            {
                entity.Id,
                entity.Name,
                entity.EIN,
                entity.CityId,
                entity.IsActivated,
                entity.IsParentCompany
            };

            try
            {
                companies = base.QueryList(Procedures.sp_select_company, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return companies;
        }

        public int Save(Company entity)
        {
            int CompanyId = 0;

            var parameters = new
            {
                entity.Name,
                entity.EIN,
                entity.CityId,
                entity.IsParentCompany,
                entity.IsActivated
            };

            try
            {
                CompanyId = base.Save(Procedures.sp_insert_company, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return CompanyId;
        }

        public void Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
