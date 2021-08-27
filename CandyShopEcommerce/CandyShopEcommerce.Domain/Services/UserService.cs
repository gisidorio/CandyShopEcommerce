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
    public class UserService : IUserService
    {
        private readonly IUserRepository _iUserRepository;

        public UserService(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

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
            return _iUserRepository.GetAll(entity);
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
