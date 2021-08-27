using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface ICompanyProductService
    {
        List<CompanyProduct> GetAll(CompanyProduct entity);
        CompanyProduct Get(CompanyProduct entity);
        void Update(CompanyProduct entity);
        int Save(CompanyProduct entity);
        void Delete(CompanyProduct entity);
    }
}
