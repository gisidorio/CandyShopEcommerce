using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public void Delete(Image entity)
        {
            throw new NotImplementedException();
        }

        public Image Get(Image entity)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAll(Image entity)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAllByProductId(Product entity)
        {
            List<Image> images = null;

            var parameters = new
            {
                entity.Id
            };

            try
            {
                images = base.QueryList(Procedures.sp_select_image_by_product_id, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return images;
        }

        public int Save(Image entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
