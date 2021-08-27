using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll(Employee entity);
        Employee Get(Employee entity);
        void Update(Employee entity);
        int Save(Employee entity);
        void Delete(Employee entity);
    }
}
