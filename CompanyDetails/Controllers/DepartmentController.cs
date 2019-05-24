using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanyDetails.Models;

namespace CompanyDetails.Controllers
{
    public class DepartmentController : Controller
    {
        // To get the departments to view the employees associated with them
        public ActionResult Index()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Department> listDepartments = dbContext.Departments.ToList();
            return View(listDepartments);
        }
    }
}