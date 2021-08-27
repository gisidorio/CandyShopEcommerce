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
    public class CompanyProductAppService : ICompanyProductAppService
    {
        private ICompanyProductService _iCompanyProductService;

        public CompanyProductAppService(ICompanyProductService iCompanyProductService)
        {
            _iCompanyProductService = iCompanyProductService;
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
            return _iCompanyProductService.GetAll(entity);
        }

        public int Save(CompanyProduct entity)
        {
            return _iCompanyProductService.Save(entity);
        }

        public void Update(CompanyProduct entity)
        {
            _iCompanyProductService.Update(entity);
        }
    }
}
