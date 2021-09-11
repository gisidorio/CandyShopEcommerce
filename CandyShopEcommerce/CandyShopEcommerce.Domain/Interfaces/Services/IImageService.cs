using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface IImageService
    {
        List<Image> GetAll(Image entity);
        Image Get(Image entity);
        void Update(Image entity);
        int Save(Image entity);
        void Delete(Image entity);
        List<Image> GetAllByProductId(Product entity);
    }
}
