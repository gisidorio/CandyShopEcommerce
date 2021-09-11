using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public void Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public Client Get(Client entity)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll(Client entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Client entity)
        {
            var ClientId = 0;

            var parameters = new
            {
                entity.Person,
                entity.Name,
                entity.EIN,
                entity.SSN,
                entity.Gender,
                entity.Email,
                entity.Phone
            };

            try
            {
                ClientId = base.Save(Procedures.sp_insert_client, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return ClientId;
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
