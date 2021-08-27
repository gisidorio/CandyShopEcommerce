using CandyShopEcommerce.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyShopEcommerce.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}