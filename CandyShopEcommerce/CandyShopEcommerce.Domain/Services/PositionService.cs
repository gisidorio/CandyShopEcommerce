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
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _iPositionRepository;

        public PositionService(IPositionRepository iPositionRepository)
        {
            _iPositionRepository = iPositionRepository;
        }

        public void Delete(Position entity)
        {
            throw new NotImplementedException();
        }

        public Position Get(Position entity)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetAll(Position entity)
        {
            return _iPositionRepository.GetAll(entity);
        }

        public int Save(Position entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Position entity)
        {
            throw new NotImplementedException();
        }
    }
}
