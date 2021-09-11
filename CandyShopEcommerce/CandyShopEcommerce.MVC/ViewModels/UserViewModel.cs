using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyShopEcommerce.MVC.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AESKey { get; set; }
        public string AESIV { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}