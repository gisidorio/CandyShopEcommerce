using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EIN { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public bool IsParentCompany { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
