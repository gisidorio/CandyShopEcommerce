using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface ICityAppService
    {
        List<City> GetAll(City entity);
        City Get(City entity);
        void Update(City entity);
        int Save(City entity);
        void Delete(City entity);
    }
}
