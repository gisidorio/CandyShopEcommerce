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
    public class EmployeesController : Controller
    {
        private readonly IEmployeeAppService _iEmployeeAppService;
        private readonly ICompanyAppService _iCompanyAppService;
        private readonly IDepartmentAppService _iDepartmentAppService;
        private readonly IPositionAppService _iPositionAppService;

        public EmployeesController
        (
            IEmployeeAppService iEmployeeAppService,
            ICompanyAppService iCompanyAppService,
            IDepartmentAppService iDepartmentAppService,
            IPositionAppService iPositionAppService
        )
        {
            _iEmployeeAppService = iEmployeeAppService;
            _iCompanyAppService = iCompanyAppService;
            _iDepartmentAppService = iDepartmentAppService;
            _iPositionAppService = iPositionAppService;
        }

        public ActionResult Index(EmployeeViewModel model)
        {
            Employee employeeEN = new Employee
            {
                Id = model.Id,
                Name = model.Name,
                SSN = model.SSN,
                Gender = model.Gender,
                Salary = model.Salary,
                CompanyId = model.CompanyId,
                DepartmentId = model.DepartmentId,
                PositionId = model.PositionId,
                IsActivated = model.IsActivated,
                RegisterDate = model.RegisterDate
            };

            var employeeListEN = _iEmployeeAppService.GetAll(employeeEN);

            var employeeListViewModel = new List<EmployeeViewModel>();

            foreach (var employee in employeeListEN)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    SSN = employee.SSN,
                    Gender = employee.Gender,
                    Salary = employee.Salary,
                    CompanyId = employee.CompanyId,
                    CompanyName = employee.CompanyName,
                    DepartmentId = employee.DepartmentId,
                    DepartmentName = employee.DepartmentName,
                    PositionId = employee.PositionId,
                    PositionName = employee.PositionName,
                    IsActivated = employee.IsActivated,
                    RegisterDate = employee.RegisterDate
                };

                employeeListViewModel.Add(employeeViewModel);
            }

            return View(employeeListViewModel);
        }

        public ActionResult Create()
        {
            var companies = _iCompanyAppService.GetAll(new Company());
            var departments = _iDepartmentAppService.GetAll(new Department());
            var positions = _iPositionAppService.GetAll(new Position());

            ViewBag.Companies = companies;
            ViewBag.Departments = departments;
            ViewBag.Positions = positions;

            return View();
        }

        public ActionResult Save(EmployeeViewModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                Name = model.Name,
                SSN = model.SSN,
                Gender = model.Gender,
                Salary = model.Salary,
                CompanyId = model.CompanyId,
                DepartmentId = model.DepartmentId,
                PositionId = model.PositionId,
                IsActivated = model.IsActivated
            };

            if (employee.Id == 0)
                _iEmployeeAppService.Save(employee);
            else
                _iEmployeeAppService.Update(employee);

            return RedirectToAction("Index");
        }

        public ActionResult Update(EmployeeViewModel model)
        {
            var companies = _iCompanyAppService.GetAll(new Company());
            var departments = _iDepartmentAppService.GetAll(new Department());
            var positions = _iPositionAppService.GetAll(new Position());

            ViewBag.Companies = companies;
            ViewBag.Departments = departments;
            ViewBag.Positions = positions;

            return View(model);
        }
    }
}