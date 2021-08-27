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
    public class PositionAppService : IPositionAppService
    {
        private readonly IPositionService _iPositionService;

        public PositionAppService(IPositionService iPositionService)
        {
            _iPositionService = iPositionService;
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
            return _iPositionService.GetAll(entity);
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
