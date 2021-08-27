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
    public class CityService : ICityService
    {
        private readonly ICityRepository _iCityRepository;

        public CityService(ICityRepository iCityRepository)
        {
            _iCityRepository = iCityRepository;
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll(City entity)
        {
            return _iCityRepository.GetAll(entity);
        }

        public int Save(City entity)
        {
            return _iCityRepository.Save(entity);
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
