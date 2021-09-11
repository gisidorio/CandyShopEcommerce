using CandyShopEcommerce.Application;
using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                AESKey = model.AESKey,
                AESIV = model.AESIV,
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
                    AESKey = user.AESKey,
                    AESIV = user.AESIV,
                    ClientId = user.ClientId,
                    EmployeeId = user.EmployeeId,
                    IsActivated = user.IsActivated,
                    RegisterDate = user.RegisterDate
                };

                userListVM.Add(userViewModel);
            }

            return View(userListVM);
        }

        public ActionResult Create(UserViewModel model)
        {
            // COLOCAR CONDIÇÃO DE SER CLIENTE OU FUNCIONARIO
            var UserVM = new UserViewModel
            {
                ClientId = model.ClientId
            };

            return View(UserVM);
        }

        public ActionResult Save(UserViewModel model)
        {
            AESCrypt s = new AESCrypt();
            Aes aes = Aes.Create();
            
            var encrypted = _iUserAppService.Encrypt(model.Password);

            var user = new User
            {
                Id = model.Id,
                Username = model.Username,
                Password = encrypted,
                ClientId = model.ClientId,
                EmployeeId = model.EmployeeId,
                IsActivated = model.IsActivated
            };

            Session["UserSession"] = user;

            if (user.Id == 0)
                _iUserAppService.Save(user);
            else
                _iUserAppService.Update(user);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Update(UserViewModel model)
        {
            var n = _iUserAppService.Decrypt(model.Password);

            var UserEN = new User
            {
                Id = model.Id,
                Username = model.Username,
                Password = _iUserAppService.Decrypt(model.Password),
                ClientId = model.ClientId,
                EmployeeId = model.EmployeeId,
                IsActivated = model.IsActivated,
                RegisterDate = model.RegisterDate
            };

            var UserVM = new UserViewModel
            {
                Id = UserEN.Id,
                Username = UserEN.Username,
                Password = UserEN.Password,
                ClientId = UserEN.ClientId,
                EmployeeId = UserEN.EmployeeId,
                IsActivated = UserEN.IsActivated,
                RegisterDate = UserEN.RegisterDate
            };

            return View(UserVM);
        }
    }
}