using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class KeywordProductViewModel
    {
        public int KeywordId { get; set; }
        public int ProductId { get; set; }
        public string Word { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}