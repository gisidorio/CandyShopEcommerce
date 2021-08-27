using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _iEmployeeRepository;

        public EmployeeService(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
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
            return _iEmployeeRepository.GetAll(entity);
        }

        public int Save(Employee entity)
        {
            return _iEmployeeRepository.Save(entity);
        }

        public void Update(Employee entity)
        {
            _iEmployeeRepository.Update(entity);
        }
    }
}
