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
    public class AuthenticationController : Controller
    {
        private readonly IUserAppService _iUserAppService;

        public AuthenticationController(IUserAppService iUserAppService)
        {
            _iUserAppService = iUserAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(UserViewModel model)
        {
            User UserEN = new User
            {
                Username = model.Username,
                Password = model.Password
            };

            var user = _iUserAppService.Login(UserEN);

            if (user != null)
            {
                Session["LoggedUser"] = user;
                return RedirectToAction("Index", "Home");
            }                

            return RedirectToAction("Index", "Home");
        }
    }
}