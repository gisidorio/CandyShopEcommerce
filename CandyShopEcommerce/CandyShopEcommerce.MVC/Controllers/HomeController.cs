using CandyShopEcommerce.Application.Interfaces;
using CandyShopEcommerce.Domain.Entities;
using CandyShopEcommerce.Domain.Interfaces.Repositories;
using CandyShopEcommerce.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyShopEcommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductAppService _iProductAppService;

        public HomeController(IProductAppService iProductAppService)
        {
            _iProductAppService = iProductAppService;
        }

        public ActionResult Index(ProductViewModel model)
        {
            var userSession = Session["LoggedUser"] as User;
            var products = _iProductAppService.GetAllProductsHome(new Product());

            var ProductViewModelList = new List<ProductViewModel>();

            foreach (var product in products)
            {
                var productViewModel = new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    ImageDirectory = product.ImageDirectory,
                    SalePrice = product.SalePrice
                };

                ProductViewModelList.Add(productViewModel);
            }

            return View(ProductViewModelList);
        }
    }
}