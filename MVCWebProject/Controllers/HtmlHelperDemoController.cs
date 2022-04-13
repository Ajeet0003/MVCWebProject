using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebProject.Controllers
{
    public class HtmlHelperDemoController : Controller
    {
        // GET: HtmlHelperDemo
        public ActionResult Index()
        {
            ViewBag.courses = new string[] { "C#", "C++", "Java" };
        
            return View();
        }
        public ViewResult StandardHelper()
        {
            ViewBag.Qualification = new string[] { "Mtech", "MCA", "BCA" };
            ViewBag.City = new SelectList( new string[] { "Dhanbad", "Patna", "Delhi" });

            return View();  
        }
        [HttpPost]
        public string StandardHelper(FormCollection form)
        {
            return "Details: " + form["Id"] + "," + form["Name"] + "," + form["gender"] + "," + form["city"];
        }
        public ViewResult TemplatedHelper()
        {
            return View();  
        }
        public ViewResult CustomerHelper()
        {
            return View();
        }
    }
}