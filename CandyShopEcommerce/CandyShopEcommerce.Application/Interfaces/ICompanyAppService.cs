using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Application.Interfaces
{
    public interface ICompanyAppService
    {
        List<Company> GetAll(Company entity);
        Company Get(Company entity);
        void Update(Company entity);
        int Save(Company entity);
        void Delete(Company entity);
    }
}
