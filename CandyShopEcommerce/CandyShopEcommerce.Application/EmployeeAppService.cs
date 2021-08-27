using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application
{
    public class EmployeeAppService : IEmployeeAppService
    {
        private IEmployeeService _iEmployeeService;

        public EmployeeAppService(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }

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
            return _iEmployeeService.GetAll(entity);
        }

        public int Save(Employee entity)
        {
            return _iEmployeeService.Save(entity);
        }

        public void Update(Employee entity)
        {
            _iEmployeeService.Update(entity);
        }
    }
}
