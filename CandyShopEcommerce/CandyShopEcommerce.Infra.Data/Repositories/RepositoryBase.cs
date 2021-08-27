using CandyShopEcommerce.Domain.Interfaces.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class RepositoryBase<T>
    {
        protected SqlConnection _conn;
        private string _connString = ConfigurationManager.ConnectionStrings["CandyShop"].ConnectionString;

        public RepositoryBase()
        {
            _conn = new SqlConnection(_connString);
        }

        protected void Delete(string procedure, object parameters = null)
        {
            _conn.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
        }

        protected T Query(string procedure, object parameters = null)
        {
            return _conn.Query<T>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();
        }

        protected List<T> QueryList(string procedure, object parameters = null)
        {
            return _conn.Query<T>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList();
        }

        protected int Save(string procedure, object parameters = null)
        {
            return _conn.Query<int>(procedure, parameters, commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();
        }

        protected void Update(string procedure, object parameters = null)
        {
            _conn.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
        }

        protected void Dispose()
        {
            _conn.Close();
        }
    }
}
