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
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _iDepartmentRepository;

        public DepartmentService(IDepartmentRepository iDepartmentRepository)
        {
            _iDepartmentRepository = iDepartmentRepository;
        }

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
            return _iDepartmentRepository.GetAll(entity);
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
