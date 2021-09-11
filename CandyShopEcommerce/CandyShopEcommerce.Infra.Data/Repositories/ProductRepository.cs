using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Product entity)
        {
            List<Product> products = null;

            var parameters = new
            {
                entity.Id,
                entity.CompanyId,
                entity.Name,
                entity.PurchasePrice,
                entity.SalePrice
            };

            try
            {
                products = base.QueryList(Procedures.sp_select_product, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return products;
        }

        public List<Product> GetAllProductsHome(Product entity)
        {
            List<Product> products = null;

            var parameters = new
            {
                entity.Id
            };

            try
            {
                products = base.QueryList(Procedures.sp_select_product_home, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return products;
        }

        public int Save(Product entity)
        {
            var ProductId = 0;

            var parameters = new
            {
                entity.Name,
                entity.Description,
                entity.PurchasePrice,
                entity.SalePrice
            };

            try
            {
                ProductId = base.Save(Procedures.sp_insert_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return ProductId;
        }

        public void Update(Product entity)
        {
            var parameters = new
            {
                entity.Id,
                entity.Name,
                entity.Description,
                entity.PurchasePrice,
                entity.SalePrice
            };

            try
            {
                base.Update(Procedures.sp_update_product, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }
        }
    }
}
