using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public class ImageAppService : IImageAppService
    {
        private readonly IImageService _iImageService;

        public ImageAppService(IImageService iImageService)
        {
            _iImageService = iImageService;
        }

        public void Delete(Image entity)
        {
            throw new NotImplementedException();
        }

        public Image Get(Image entity)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAll(Image entity)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAllByProductId(Product entity)
        {
            return _iImageService.GetAllByProductId(entity);
        }

        public int Save(Image entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
