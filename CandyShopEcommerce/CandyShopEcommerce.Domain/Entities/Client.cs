using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Name { get; set; }
        public string EIN { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
