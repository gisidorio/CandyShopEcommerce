using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class Procedures
    {
        #region CITIES
        public static readonly string sp_select_city = "sp_select_city";
        #endregion        

        #region COMPANIES
        public static readonly string sp_select_company = "sp_select_company";
        public static readonly string sp_insert_company = "sp_insert_company";
        #endregion

        #region DEPARTMENTS
        public static readonly string sp_select_department = "sp_select_department";
        #endregion

        #region EMPLOYEES
        public static readonly string sp_select_employee = "sp_select_employee";
        public static readonly string sp_insert_employee = "sp_insert_employee";
        public static readonly string sp_update_employee = "sp_update_employee";
        #endregion

        #region POSITIONS
        public static readonly string sp_select_position = "sp_select_position";        
        #endregion

        #region PRODUCTS
        public static readonly string sp_select_product = "sp_select_product";
        #endregion

        #region COMPANY X PRODUCTS
        public static readonly string sp_insert_company_product = "sp_insert_company_product";
        public static readonly string sp_select_company_product = "sp_select_company_product";
        public static readonly string sp_update_company_product = "sp_update_company_product";
        #endregion

        #region USERS
        public static readonly string sp_select_user = "sp_select_user";
        #endregion
    }
}
