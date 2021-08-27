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
    public class CityAppService : ICityAppService
    {
        private readonly ICityService _iCityService;

        public CityAppService(ICityService iCityService)
        {
            _iCityService = iCityService;
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public City Get(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll(City entity)
        {
            return _iCityService.GetAll(entity);
        }

        public int Save(City entity)
        {
            return _iCityService.Save(entity);
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
