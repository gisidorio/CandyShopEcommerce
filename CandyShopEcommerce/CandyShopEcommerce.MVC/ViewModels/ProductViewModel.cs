using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public bool IsActivated { get; set; }
        public string ImageDirectory { get; set; }
        public DateTime? RegisterDate { get; set; }
        public List<FAQViewModel> FAQs { get; set; }
        public List<ImageViewModel> Images { get; set; }
    }
}