using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopEcommerce.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }
}
