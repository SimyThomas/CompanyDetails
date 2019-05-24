using System;
using CompanyDetails.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompanyDetails.Models;


namespace Company_Test
{
    [TestClass]
    public class CompanyTest
    {
        //Create employee
        [TestMethod]
        public void CreateEmployeeTest()
        {
            
            EmployeesDetailsController controller = new EmployeesDetailsController();

            var employee = defaultEmployee();

            ActionResult result = controller.Create(employee);
            // Assert
            Assert.IsNotNull(result);
        }

        //Get the list of employees
        [TestMethod]
        public void GetEmployeesTest()
        {
            EmployeesDetailsController controller = new EmployeesDetailsController();
            ActionResult result = controller.Index();
            // Assert
            Assert.IsNotNull(result);
        }


        //Create department
        [TestMethod]
        public void CreateDepartmentTest()
        {
            DepartmentsDetailsController controller = new DepartmentsDetailsController();

            var department = defaultDepartment();

            ActionResult result = controller.Create(department);
            // Assert
            Assert.IsNotNull(result);
        }

        //Get the list of departments
        [TestMethod]
        public void GetDepartmentsTest()
        {
            DepartmentsDetailsController controller = new DepartmentsDetailsController();
            ActionResult result = controller.Index();
            // Assert
            Assert.IsNotNull(result);
        }
        //Default employee
        private Employee defaultEmployee()
        {
            Employee emp = new Employee();
        emp.First_Name = "Mathew";
        emp.Last_Name = "John";
        emp.City = "Auburn";
        emp.Email_Id = "Mathew@yahoo.com";
        emp.State = "CA";
        emp.Street_Address = "1444 Greenback ln";
        emp.Phone_Number = "945-612-8756";
        //1-IT ,2-HR,3-Marketing,4-Claims
        emp.Department_Id = 2;
        return emp;
        }
        
        //Default Department
        private Department defaultDepartment()
        {
            Department dept = new Department();
            dept.Department_Name= "TestDepartment";
            return dept;
        }
    }
}
