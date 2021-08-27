﻿using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface IUserAppService
    {
        List<User> GetAll(User entity);
        User Get(User entity);
        void Update(User entity);
        int Save(User entity);
        void Delete(User entity);
    }
}
