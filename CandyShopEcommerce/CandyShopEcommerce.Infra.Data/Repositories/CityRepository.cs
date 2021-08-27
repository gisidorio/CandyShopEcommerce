using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
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
            List<City> cities = null;

            var parameters = new
            {
                entity.Id,
                entity.StateId,
                entity.CityName
            };

            try
            {
                cities = base.QueryList(Procedures.sp_select_city, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return cities;
        }

        public int Save(City entity)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
