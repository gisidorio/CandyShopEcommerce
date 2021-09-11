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
    public class ImageService : IImageService
    {
        private readonly IImageRepository _iImageRepository;

        public ImageService(IImageRepository iImageRepository)
        {
            _iImageRepository = iImageRepository;
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
            return _iImageRepository.GetAllByProductId(entity);
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
