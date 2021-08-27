﻿using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface IProductAppService
    {
        List<Product> GetAll(Product entity);
        Product Get(Product entity);
        void Update(Product entity);
        int Save(Product entity);
        void Delete(Product entity);
    }
}
