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
    public class CompanyAppService : ICompanyAppService
    {
        private ICompanyService _iCompanyService;

        public CompanyAppService(ICompanyService iCompanyService)
        {
            _iCompanyService = iCompanyService;                
        }

        public void Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public Company Get(Company entity)
        {
            return _iCompanyService.Get(entity);
        }

        public List<Company> GetAll(Company entity)
        {
            return _iCompanyService.GetAll(entity);
        }

        public int Save(Company entity)
        {
            return _iCompanyService.Save(entity);
        }

        public void Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
