using CandyShopEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Services
{
    public interface ICompanyService    
    {
        List<Company> GetAll(Company entity);
        Company Get(Company entity);
        void Update(Company entity);
        int Save(Company entity);
        void Delete(Company entity);

    }
}
