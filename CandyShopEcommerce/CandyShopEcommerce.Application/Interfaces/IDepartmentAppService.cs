using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface IDepartmentAppService
    {
        List<Department> GetAll(Department entity);
        Department Get(Department entity);
        void Update(Department entity);
        int Save(Department entity);
        void Delete(Department entity);
    }
}
