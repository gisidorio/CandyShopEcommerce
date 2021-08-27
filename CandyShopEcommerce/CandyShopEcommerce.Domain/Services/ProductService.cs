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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _iProductRepository;

        public ProductService(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        public List<Product> GetAll(Product entity)
        {
            return _iProductRepository.GetAll(entity);
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
