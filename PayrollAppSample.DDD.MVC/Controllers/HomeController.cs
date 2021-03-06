﻿using PayrollAppSample.DDD.Domain.Services.Implementation;
using PayrollAppSample.DDD.MVC.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayrollAppSample.DDD.MVC.Controllers {
    public class HomeController : Controller {

        private readonly IHumanResourceService _empService;
        public HomeController(IHumanResourceService empService) {
            _empService = empService;
        }

        public ActionResult Index() {
            ViewBag.Title = "Home Page";
            //_empService.AddEmployee(new Domain.ViewModels.EmployeeViewModel() {
            //    Fname = "Sonny"
            //});
            //_empService.AddEmployee(new Domain.ViewModels.EmployeeViewModel() {
            //    Fname = "Sonny"
            //});

            return View();
        }
    }
}
