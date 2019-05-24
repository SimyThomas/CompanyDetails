using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanyDetails.Models;

namespace CompanyDetails.Controllers
{
    public class EmployeeController : Controller
    {
        //Get the employees for the department selected
        public ActionResult Index(int departmentId)
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            var employees = dbContext.Employees.Where(emp => emp.Department_Id == departmentId).ToList();
            return View(employees);
        }
       
    }
}