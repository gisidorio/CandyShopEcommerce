using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
