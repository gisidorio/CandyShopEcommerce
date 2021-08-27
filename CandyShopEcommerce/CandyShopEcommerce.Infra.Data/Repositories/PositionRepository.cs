using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class PositionRepository : RepositoryBase<Position>, IPositionRepository
    {
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
            List<Position> positions = null;

            var parameters = new
            {
                entity.Id,
                entity.Name
            };

            try
            {
                positions = base.QueryList(Procedures.sp_select_position, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return positions;
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
