using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebProject.Controllers;
using MVCWebProject.Models;

namespace MVCWebProject.Controllers
{    
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult Index()
        {
            return View();
        }
        //using Parameter

        [HttpPost]
        public string Index(string fname, string lname)
        {
            return "data using Parameter: " + fname + "&nbsp;" + lname;
        }
        //Using Request

        [HttpPost]
        public string PostUsingRequest()
        {
            return "Data using Request:" + Request["fname"] + "&nbsp;" + Request["lname"];
        }
        
        //Using FormCollection
        [HttpPost]
        public string PostUsingForm(FormCollection form)
        {
            return "Method using FormCollection:" + form["fname"] + "&nbsp;" + form["lname"];
        }
        //get : Passing data
        public ViewResult RegisterStudent()
        {
            return View();
        }
        //post using Model
        //[HttpPost]
        //public string  RegisterStudent(Student student)
        //{
        //    return $"Data using model: ID:{ student.Id}"+$"Name: { student.Name}Address:{ student.Address}Mark: { student.Mark} ";
        //}

       // post using model
        [HttpPost]
        public ViewResult RegisterStudent(Student student)
        {
            return View("Details",student); 
        }

    }
}