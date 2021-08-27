using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(User entity)
        {
            List<User> users = null;

            var parameters = new
            {
                entity.Id,
                entity.Username,
                entity.Password,
                entity.ClientId,
                entity.EmployeeId,
                entity.IsActivated,
                entity.RegisterDate
            };

            try
            {
                users = base.QueryList(Procedures.sp_select_user, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return users;
        }

        public int Save(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
