﻿using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface IPositionAppService
    {
        List<Position> GetAll(Position entity);
        Position Get(Position entity);
        void Update(Position entity);
        int Save(Position entity);
        void Delete(Position entity);
    }
}
