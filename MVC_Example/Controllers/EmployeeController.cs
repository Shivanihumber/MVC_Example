using MVC_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Employee employee = new Employee();
            EmployeeContext employeeContext = new EmployeeContext();
            employee.name = formCollection["Name"];
            employee.name = formCollection["Gender"];

            employee.name = formCollection["City"];
            employee.departmentId = Convert.ToInt32(formCollection["DepartmentID"]);
            employeeContext.Employees.Add(employee);
            employeeContext.SaveChanges();
            return RedirectToAction("Index", new { id = employee.departmentId});

        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.departmentId == id).ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp=>emp.Id==id);
            return View(employee);
        }
    }
}