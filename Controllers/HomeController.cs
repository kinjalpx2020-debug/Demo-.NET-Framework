using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            Console.WriteLine(data);
            return View(data);
        }
        public ViewResult About()
        {
            //ViewBag.Message = "Your application description page.";
            return View();
        }
        public ViewResult ContactUs()
        {
            //ViewBag.Message = "Your contact page.";

            return View("~/Views/MyView/MyIndex.cshtml");
        }
        private Employee GetEmployee()
        {
            return new Employee
            {
                Id = 1,
                Name = "John Doe",
                Department = "IT"
            };
        }
    }
}