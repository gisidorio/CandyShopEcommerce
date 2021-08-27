using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface ICityService
    {
        List<City> GetAll(City entity);
        Product Get(City entity);
        void Update(City entity);
        int Save(City entity);
        void Delete(City entity);
    }
}
