﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() {
            return View();
        }
        [HttpPost]       
        public string PostUsingParameters(string firstName, string lastName) {
            return "From Parameters " + firstName + ", " + lastName;
        }
        [HttpPost]
        public string PostUsingRequest() {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "From Request " + firstName + ", " + lastName;
        }
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form) {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "From FormCollection " + firstName + ", " + lastName;
        }
        public string PostUsingBinding(Employee emp) {            
            return "From binding " + emp.firstName + ", " + emp.lastName;
        }
    }
}