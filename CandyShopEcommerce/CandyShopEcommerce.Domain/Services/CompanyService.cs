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
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _iCompanyRepository;

        public CompanyService(ICompanyRepository iCompanyRepository)
        {
            _iCompanyRepository = iCompanyRepository;
        }

        public void Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public Company Get(Company entity)
        {
            return _iCompanyRepository.Get(entity);
        }

        public List<Company> GetAll(Company entity)
        {
            return _iCompanyRepository.GetAll(entity);
        }

        public int Save(Company entity)
        {
            return _iCompanyRepository.Save(entity);
        }

        public void Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
