using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {        
        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Employee entity)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Employee entity)
        {
            List<Employee> employees = null;

            var parameters = new
            {
                entity.Id,
                entity.Name,
                entity.SSN,
                entity.Gender,
                entity.Salary,
                entity.CompanyId,
                entity.DepartmentId,
                entity.PositionId,
                entity.IsActivated,
                entity.InitialDate,
                entity.FinalDate
            };

            try
            {
                employees = base.QueryList(Procedures.sp_select_employee, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return employees;
        }

        public int Save(Employee entity)
        {
            var EmployeeId = 0;

            var parameters = new
            {
                entity.Name,
                entity.SSN,
                entity.Gender,
                entity.Salary,
                entity.CompanyId,
                entity.DepartmentId,
                entity.PositionId,
                entity.IsActivated
            };

            try
            {
                EmployeeId = base.Save(Procedures.sp_insert_employee, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return EmployeeId;
        }

        public void Update(Employee entity)
        {
            var parameters = new
            {
                entity.Id,
                entity.Name,
                entity.SSN,
                entity.Gender,
                entity.Salary,
                entity.CompanyId,
                entity.DepartmentId,
                entity.PositionId,
                entity.IsActivated
            };

            try
            {
                base.Update(Procedures.sp_update_employee, parameters);
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
