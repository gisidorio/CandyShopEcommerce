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
    public class CompaniesController : Controller
    {
        private readonly ICompanyAppService _companyAppService;
        private readonly IProductAppService _productAppService;
        private readonly ICompanyProductAppService _companyProductAppService;
        private readonly ICityAppService _cityAppService;

        public CompaniesController
        (
            ICompanyAppService companyAppService, 
            IProductAppService productAppService,
            ICompanyProductAppService companyProductAppService,
            ICityAppService cityAppService
        )
        {
            _companyAppService = companyAppService;
            _productAppService = productAppService;
            _companyProductAppService = companyProductAppService;
            _cityAppService = cityAppService;
        }

        public ActionResult Index(CompanyViewModel model)
        {
            var companyEN = new Company
            {
                Id = model.Id,
                EIN = model.EIN,
                Name = model.Name,
                CityId = model.CityId,
                IsParentCompany = model.IsParentCompany,
                IsActivated = model.IsActivated,
                RegisterDate = model.RegisterDate
            };

            #region COMPANIES CONVERSION ENTITY LIST TO VIEW MODEL
            var companyListEN = _companyAppService.GetAll(companyEN);

            var companyListViewModel = new List<CompanyViewModel>();

            foreach (var company in companyListEN)
            {
                CompanyViewModel companyViewModel = new CompanyViewModel
                {
                    Id = company.Id,
                    Name = company.Name,
                    EIN = company.EIN,
                    CityId = company.CityId,
                    CityName = company.CityName,
                    IsParentCompany = company.IsParentCompany,
                    IsActivated = company.IsActivated,
                    RegisterDate = company.RegisterDate
                };

                companyListViewModel.Add(companyViewModel);
            }
            #endregion

            return View(companyListViewModel);
        }

        public ActionResult EditForm(CompanyViewModel model)
        {           
            var companyProducts = new CompanyProduct
            {
                CompanyId = model.Id
            };

            var product = new Product
            {
                CompanyId = model.Id
            };

            var companyProductsList = _companyProductAppService.GetAll(companyProducts);

            var productsList = _productAppService.GetAll(product);

            ViewBag.ProductsNotStock = productsList;
            ViewBag.CompanyProducts = companyProductsList;

            return View(model);
        }

        public ActionResult Create()
        {
            var cityEN = new City();
            var product = new Product();

            var cities = _cityAppService.GetAll(cityEN);
            var productsList = _productAppService.GetAll(product);

            ViewBag.ProductsNotStock = productsList;

            return View(cities);
        }

        public ActionResult UpdateProductCompanyStock(CompanyProduct productStock)
        {
            _companyProductAppService.Update(productStock);
            return Json("");
        }

        public ActionResult SaveProductsCompany(List<CompanyProduct> productsList)
        {
            foreach (var productsCompany in productsList)
            {
                _companyProductAppService.Save(productsCompany);
            }            

            return Json("");
        }

        public ActionResult ListProductsForSave(List<CompanyProduct> productsList)
        {
            Session["ProductsList"] = productsList;
            return null;
        }

        public ActionResult Save(CompanyViewModel model)
        {
            var company = new Company
            {
                Id = model.Id,
                Name = model.Name,
                EIN = model.EIN,
                CityId = model.CityId,
                CityName = model.CityName,
                IsParentCompany = model.IsParentCompany,
                IsActivated = model.IsActivated
            };

            if (model.Id == 0)
            {
                var CompanyId = _companyAppService.Save(company);
                
                if (Session["ProductsList"] != null)
                {
                    List<CompanyProduct> companyProducts = (List<CompanyProduct>)Session["ProductsList"];

                    foreach (var companyProduct in companyProducts)
                    {
                        companyProduct.CompanyId = CompanyId;
                        _companyProductAppService.Save(companyProduct);
                    }
                }

                Session["ProductsList"] = null;

                return RedirectToAction("Index", "Companies");
            }
            else
            {
                
            }

            return null;
        }
    }
}