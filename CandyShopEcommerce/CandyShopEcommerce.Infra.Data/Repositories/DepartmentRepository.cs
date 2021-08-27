using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public void Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Get(Department entity)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll(Department entity)
        {
            List<Department> departments = null;

            var parameters = new
            {
                entity.Id,
                entity.Name
            };

            try
            {
                departments = base.QueryList(Procedures.sp_select_department, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return departments;
        }

        public int Save(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
