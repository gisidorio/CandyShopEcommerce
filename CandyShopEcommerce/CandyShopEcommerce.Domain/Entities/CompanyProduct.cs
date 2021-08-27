using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class CompanyProduct
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
        public string Name { get; set; }
    }
}
