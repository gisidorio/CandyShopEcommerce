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
    public class ClientsController : Controller
    {
        private readonly IClientAppService _iClientAppService;

        public ClientsController(IClientAppService iClientAppService)
        {
            _iClientAppService = iClientAppService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Save(ClientViewModel model)
        {
            var client = new Client
            {
                Id = model.Id,
                Person = model.Person,
                Name = model.Name,
                EIN = model.EIN,
                SSN = model.SSN,
                Gender = model.Gender,
                Email = model.Email,
                Phone = model.Phone
            };

            if (client.Id == 0)
            {
                var UserVM = new UserViewModel();
                UserVM.ClientId = _iClientAppService.Save(client);
                return RedirectToAction("Create", "Users", UserVM);
            }                
            else
                _iClientAppService.Update(client);

            return null;
        }
    }
}