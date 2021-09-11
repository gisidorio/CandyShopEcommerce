using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class FAQViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ProductId { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}