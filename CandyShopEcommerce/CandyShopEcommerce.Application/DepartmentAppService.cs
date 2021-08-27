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
    public class DepartmentAppService : IDepartmentAppService
    {
        private readonly IDepartmentService _iDepartmentService;

        public DepartmentAppService(IDepartmentService iDepartmentService)
        {
            _iDepartmentService = iDepartmentService;
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
            return _iDepartmentService.GetAll(entity);
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
