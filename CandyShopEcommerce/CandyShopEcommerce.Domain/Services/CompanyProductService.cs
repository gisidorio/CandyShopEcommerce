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
    public class CompanyProductService : ICompanyProductService
    {
        private readonly ICompanyProductRepository _iCompanyProductRepository;

        public CompanyProductService(ICompanyProductRepository iCompanyProductRepository)
        {
            _iCompanyProductRepository = iCompanyProductRepository;
        }

        public void Delete(CompanyProduct entity)
        {
            throw new NotImplementedException();
        }

        public CompanyProduct Get(CompanyProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<CompanyProduct> GetAll(CompanyProduct entity)
        {
            return _iCompanyProductRepository.GetAll(entity);
        }

        public int Save(CompanyProduct entity)
        {
            return _iCompanyProductRepository.Save(entity);
        }

        public void Update(CompanyProduct entity)
        {
            _iCompanyProductRepository.Update(entity);
        }
    }
}
