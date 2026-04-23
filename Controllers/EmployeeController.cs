using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Profile(int i, string dept) { 
            int profile=i==1?1:0;
            return "The ID is "+profile+" The department is "+dept;
        }
    }
}