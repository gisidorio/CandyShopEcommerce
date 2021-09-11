using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Infra.Data.Repositories
{
    public class Procedures
    {
        #region CLIENTS
        public static readonly string sp_insert_client = "sp_insert_client";
        #endregion

        #region CITIES
        public static readonly string sp_select_city = "sp_select_city";
        #endregion        

        #region COMPANIES
        public static readonly string sp_select_company = "sp_select_company";
        public static readonly string sp_insert_company = "sp_insert_company";
        #endregion

        #region COMPANY X PRODUCTS
        public static readonly string sp_insert_company_product = "sp_insert_company_product";
        public static readonly string sp_select_company_product = "sp_select_company_product";
        public static readonly string sp_update_company_product = "sp_update_company_product";
        #endregion

        #region DEPARTMENTS
        public static readonly string sp_select_department = "sp_select_department";
        #endregion

        #region EMPLOYEES
        public static readonly string sp_select_employee = "sp_select_employee";
        public static readonly string sp_insert_employee = "sp_insert_employee";
        public static readonly string sp_update_employee = "sp_update_employee";
        #endregion

        #region FAQS
        public static readonly string sp_insert_faq = "sp_insert_faq";
        #endregion

        #region KEYWORDS
        
        #endregion

        #region POSITIONS
        public static readonly string sp_select_position = "sp_select_position";
        #endregion

        #region PRODUCTS
        public static readonly string sp_insert_product = "sp_insert_product";
        public static readonly string sp_select_product = "sp_select_product";
        public static readonly string sp_select_product_home = "sp_select_product_home";
        public static readonly string sp_update_product = "sp_update_product";
        public static readonly string sp_select_faq_product = "sp_select_faq_product";
        public static readonly string sp_select_image_by_product_id = "sp_select_image_by_product_id";
        public static readonly string sp_select_keyword_not_in_product = "sp_select_keyword_not_in_product";
        
        #endregion

        #region PRODUCT X KEYWORDS
        public static readonly string sp_select_keyword_product = "sp_select_keyword_product";
        public static readonly string sp_insert_keyword_product = "sp_insert_keyword_product";
        #endregion        

        #region USERS
        public static readonly string sp_select_user = "sp_select_user";
        public static readonly string sp_insert_user = "sp_insert_user";
        public static readonly string sp_login = "sp_login";
        #endregion
    }
}
