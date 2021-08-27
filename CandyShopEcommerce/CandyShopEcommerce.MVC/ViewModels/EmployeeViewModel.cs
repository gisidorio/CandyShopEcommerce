using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class EmployeeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Input the company name")]
        [MaxLength(60, ErrorMessage = "{0} caracteres maximum")]
        [MinLength(2, ErrorMessage = "{0} caracteres minimum")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Input the company EIN")]
        [MaxLength(9, ErrorMessage = "{0} caracteres maximum")]
        [MinLength(9, ErrorMessage = "{0} caracteres minimum")]
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
    }
}