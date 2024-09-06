using G6.NetITIMVCDay03.Context;
using G6.NetITIMVCDay03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace G6.NetITIMVCDay03.Controllers
{
    public class EmployeeController : Controller
    {
        /*-------------------------------------------------*/
        // Context
        CompanyContext db = new CompanyContext();
        /*-------------------------------------------------*/
        // Index - List of All Employees 
        [HttpGet]
        public IActionResult Index()
        {
            var _Employees = db.Employees.Include(emp => emp.Department);
            return View(_Employees);
        }
        /*-------------------------------------------------*/
        // View Details - View Details of a specific Employee
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var _SingleEmp = db.Employees.Include(e => e.Department).FirstOrDefault(emp => emp.Id == id);
            if ( _SingleEmp == null )
            {
                return RedirectToAction("Index");
            }
            return View(_SingleEmp);
        }
        /*-------------------------------------------------*/
        // Create - Get Method to show the form for creating a new Employee (Return View)
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag._Departments = new SelectList(db.Departments, "Id", "DeptName");
            return View();
        }
        /*-------------------------------------------------*/
        // Create - Post Method to Save/Add a New Employee to Data Base
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Edit - Get Method to show the form for Editing a Employee (Return View)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var oldEmployee = db.Employees.Include(e => e.Department).FirstOrDefault(emp => emp.Id == id);
            if (oldEmployee == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag._Departments = new SelectList(db.Departments, "Id", "DeptName");
            return View(oldEmployee);
        }
        /*-------------------------------------------------*/
        // Edit - Post Method to save Changes to Data Base
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            var oldEmployee = db.Employees.FirstOrDefault(emp => emp.Id == employee.Id);
            if (oldEmployee == null)
            {
                return RedirectToAction("Index");
            }
            oldEmployee.Name = employee.Name;
            oldEmployee.Age = employee.Age;
            oldEmployee.Salary = employee.Salary;
            oldEmployee.DepartmentId = employee.DepartmentId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Delete 
        public IActionResult Delete(int id)
        {
            var employeeToDelete = db.Employees.Find(id);
            if (employeeToDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Employees.Remove(employeeToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
    }
}
