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
    public class ProductsController : Controller
    {
        private readonly IProductAppService _iProductAppService;
        private readonly IFAQAppService _iFAQAppService;
        private readonly IImageAppService _iImageAppService;
        private readonly IKeywordProductAppService _iKeywordProductAppService;
        private readonly IKeywordAppService _ikeywordAppService;

        public ProductsController
        (
            IProductAppService iProductAppService,
            IFAQAppService iFAQAppService,
            IKeywordProductAppService iKeywordProductAppService,
            IKeywordAppService iKeywordAppService,
            IImageAppService iImageAppService
        )
        {
            _iProductAppService = iProductAppService;
            _iFAQAppService = iFAQAppService;
            _iKeywordProductAppService = iKeywordProductAppService;
            _ikeywordAppService = iKeywordAppService;
            _iImageAppService = iImageAppService;
        }

        public ActionResult Index(ProductViewModel model)
        {
            var productEN = new Product
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                IsActivated = model.IsActivated
            };

            var products = _iProductAppService.GetAll(productEN);

            var productsViewModel = new List<ProductViewModel>();

            foreach (var product in products)
            {
                var productVM = new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    PurchasePrice = product.PurchasePrice,
                    SalePrice = product.SalePrice,
                    IsActivated = product.IsActivated,
                    RegisterDate = product.RegisterDate
                };

                productsViewModel.Add(productVM);
            }

            return View(productsViewModel);
        }

        public ActionResult Details(ProductViewModel model)
        {
            var ProductEN = new Product
            {
                Id = model.Id
            };

            #region MAPPING FAQ ENTITY TO VIEW MODEL
            var FAQs = _iFAQAppService.GetAllByProductId(ProductEN);

            var FAQsVM = new List<FAQViewModel>();

            foreach (var faq in FAQs)
            {
                var FAQVM = new FAQViewModel
                {
                    Id = faq.Id,
                    Question = faq.Question,
                    Answer = faq.Answer,
                    ProductId = faq.ProductId,
                    RegisterDate = faq.RegisterDate
                };

                FAQsVM.Add(FAQVM);
            }

            model.FAQs = FAQsVM;
            #endregion

            #region MAPPING IMAGES ENTITY TO VIEW MODEL
            var Images = _iImageAppService.GetAllByProductId(ProductEN);

            var ImagesVM = new List<ImageViewModel>();

            foreach (var image in Images)
            {
                var ImageVM = new ImageViewModel
                {
                    Id = image.Id,
                    Directory = image.Directory,
                    ProductId = image.ProductId
                };

                ImagesVM.Add(ImageVM);
            }

            model.Images = ImagesVM;
            #endregion

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Save(ProductViewModel model)
        {
            var product = new Product
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                IsActivated = model.IsActivated
            };

            if (model.Id == 0)
                _iProductAppService.Save(product);
            else
                _iProductAppService.Update(product);

            return RedirectToAction("Index", "Products");
        }

        public ActionResult SaveProductKeywords(List<KeywordProduct> keywordsList)
        {
            foreach (var KeywordProduct in keywordsList)
            {
                _iKeywordProductAppService.Save(KeywordProduct);
            }

            return Json("");
        }

        public ActionResult Update(ProductViewModel model)
        {
            KeywordProduct KeywordProductEN = new KeywordProduct
            {
                ProductId = model.Id
            };

            var ProductEN = new Product
            {
                Id = model.Id
            };

            var keywords = _iKeywordProductAppService.GetKeywordsByProduct(KeywordProductEN);
            var faqs = _iFAQAppService.GetAllByProductId(ProductEN);
            var KeywordsNotInProduct = _ikeywordAppService.KeywordsNotInProduct(ProductEN);

            ViewBag.Keywords = keywords;
            ViewBag.FAQs = faqs;
            ViewBag.KeywordsNotInProduct = KeywordsNotInProduct;

            return View(model);
        }
    }
}