using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public string ImageDirectory { get; set; }
        public bool IsActivated { get; set; }
        public List<FAQ> FAQs { get; set; }
        public List<Image> Images { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
