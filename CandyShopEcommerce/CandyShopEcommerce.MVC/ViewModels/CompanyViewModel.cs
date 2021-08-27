using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class CompanyViewModel
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
        public string EIN { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public bool IsParentCompany { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}