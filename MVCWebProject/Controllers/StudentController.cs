using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Route("students/{sid?}")]
        public ActionResult Index(string sid)
        {
            ViewBag.Id = sid;
            return View();
        }
        [Route("students/{studentId}/courses")]
        public ViewResult GetStudentCourses(int ? studentId)
        {
            List<string> courses= new List<string>();
            switch (studentId)
            {
                case 1:
                    courses= new List<string> { "C", "c++", "java" };
                    break;
                    case 2:
                    courses = new List<string> { "Asp.net", "c" };
                    break;
                    default:
                    courses = new List<string> { "networking", "c/c++" };
                    break ;
            }
            ViewBag.Courses = courses;
            return View();

        }
    }
}