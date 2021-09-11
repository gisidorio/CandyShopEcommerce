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
                entity.IsActivated
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

        public User Login(User entity)
        {
            User user = null;

            var parameters = new
            {
                entity.Username,
                entity.Password
            };

            try
            {
                user = base.Query(Procedures.sp_login, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return user;
        }

        public int Save(User entity)
        {
            var UserId = 0;

            var parameters = new
            {
                entity.Username,
                entity.Password,
                entity.ClientId,
                entity.EmployeeId
            };

            try
            {
                UserId = base.Save(Procedures.sp_insert_user, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return UserId;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
