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
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _iUserService;

        public UserAppService(IUserService iUserService)
        {
            _iUserService = iUserService;
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
            return _iUserService.GetAll(entity);
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
