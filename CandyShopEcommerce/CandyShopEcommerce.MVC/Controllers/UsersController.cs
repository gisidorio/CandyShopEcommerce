using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyShopEcommerce.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserAppService _iUserAppService;

        public UsersController(IUserAppService iUserAppService)
        {
            _iUserAppService = iUserAppService;
        }

        public ActionResult Index(UserViewModel model)
        {
            var userEN = new User
            {
                Id = model.Id,
                Username = model.Username,
                Password = model.Password,
                ClientId = model.ClientId,
                EmployeeId = model.EmployeeId,
                IsActivated = model.IsActivated,
                RegisterDate = model.RegisterDate
            };

            var UsersListEN = _iUserAppService.GetAll(userEN);

            var userListVM = new List<UserViewModel>();

            foreach (var user in UsersListEN)
            {
                UserViewModel userViewModel = new UserViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    ClientId = user.ClientId,
                    EmployeeId = user.EmployeeId,
                    IsActivated = user.IsActivated,
                    RegisterDate = user.RegisterDate
                };

                userListVM.Add(userViewModel);
            }

            return View(userListVM);
        }
    }
}