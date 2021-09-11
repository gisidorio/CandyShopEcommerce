using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface IFAQService
    {
        List<FAQ> GetAll(FAQ entity);
        FAQ Get(FAQ entity);
        void Update(FAQ entity);
        int Save(FAQ entity);
        void Delete(FAQ entity);
        List<FAQ> GetAllByProductId(Product entity);
    }
}
