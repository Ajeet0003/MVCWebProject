using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebProject.Models;

namespace MVCWebProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public string Name()
        {
            return "Ajeet";
        }
        public string Hello()
        {
            return "Welcome to ASP.NET MVC";
        }
        string Id()
        {
            return "1";
        }
        public string EmpProfile(int ? id)//?=nullable
        {
            string profile=string.Empty;
            switch (id)
            {
                case 1: profile = "Emp1 profile";
                    break;
                    case 2: profile = "Emp 2 profile";
                    break ;
                case 3:
                    profile = "Emp 3 profile";
                    break;
                    default: profile = "no emp found";
                    break;
            }
            return profile;
        }
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Employee contact us view page";
            ViewBag.Id = 1000;
            return View();
        }
        public ViewResult AboutUs()
        {
            ViewBag.Message = "Employee About us view page";
            return View();
        }
        public ViewResult GetAllEmployee()
        {
            ViewBag.Message = "Get All Employee view page";
            return View("GetEmployee");//passing a viewname other than action name to render the response
        }
        //method to return Employee object

        Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1000,
                Name = "Admin",
                Salary = 6542.8f

            };
        }
        public ViewResult ViewEmployee()
        {
            var emp = GetEmployee();

            return View(emp);//passing employee model object with view
        }
    }
}