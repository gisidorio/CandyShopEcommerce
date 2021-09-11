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
    public class FAQsController : Controller
    {
        private readonly IFAQAppService _iFAQAppService;

        public FAQsController(IFAQAppService iFAQAppService)
        {
            _iFAQAppService = iFAQAppService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(FAQViewModel model)
        {
            var FAQId = 0;

            var FAQEN = new FAQ
            {
                Id = model.Id,
                Question = model.Question,
                Answer = model.Answer,
                ProductId = model.ProductId
            };

            if (model.Id == 0)
                FAQId = _iFAQAppService.Save(FAQEN);
            else
                _iFAQAppService.Update(FAQEN);

            return Json(FAQId);
        }
    }
}