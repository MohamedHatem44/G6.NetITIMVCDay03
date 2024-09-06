using G6.NetITIMVCDay03.Context;
using G6.NetITIMVCDay03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G6.NetITIMVCDay03.Controllers
{
    public class DepartmentController : Controller
    {
        /*-------------------------------------------------*/
        // Context
        CompanyContext db = new CompanyContext();
        /*-------------------------------------------------*/
        // Index - List of All Departments 
        [HttpGet]
        public IActionResult Index()
        {
            var _Departments = db.Departments;
            return View(_Departments);
        }
        /*-------------------------------------------------*/
        // View Details - View Details of a specific Department
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var _Department = db.Departments.Find(id);
            if (_Department == null)
            {
                return RedirectToAction("Index");
            }
            return View(_Department);
        }
        /*-------------------------------------------------*/
        // Create - Get Method to show the form for creating a new Department (Return View)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /*-------------------------------------------------*/
        // Create - Post Method to Save/Add a New Department to Data Base
        [HttpPost]
        public IActionResult Create(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Edit - Get Method to show the form for Editing a Department (Return View)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var oldDepartment = db.Departments.Find(id);
            if (oldDepartment == null)
            {
                return RedirectToAction("Index");
            }
            return View(oldDepartment); 
        }
        /*-------------------------------------------------*/
        // Edit - Post Method to save Changes to Data Base
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            var oldDepartment = db.Departments.FirstOrDefault(d => d.Id == department.Id);
            if (oldDepartment == null)
            {
                return RedirectToAction("Index");
            }
            oldDepartment.DeptName = department.DeptName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Delete
        public IActionResult Delete(int id)
        {
            var deptToDelete = db.Departments.Find(id);
            if (deptToDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Departments.Remove(deptToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
    }
}
