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
    public class ProductAppService : IProductAppService
    {
        private IProductService _iProductService;

        public ProductAppService(IProductService iProductService)
        {
            _iProductService = iProductService;
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Product entity)
        {
            return _iProductService.GetAll(entity);
        }

        public int Save(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
