using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        int Save(T entity);
        List<T> GetAll(T entity);
        T Get(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
