using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class CompanyProductViewModel
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
        public string ProductName { get; set; }
    }
}