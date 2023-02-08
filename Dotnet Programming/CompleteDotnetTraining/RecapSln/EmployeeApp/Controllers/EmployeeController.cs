using DataAccessLib;
using DataAccessLib.EmployeeLib;
using EmployeeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeComponent _repo = new EmployeeComponent();
        // GET: Employee
        public ActionResult Index()
        {
            return View(); //This is the Dashboard. No Model
        }

        public ActionResult AllEmployees()
        {
            var model = _repo.GetAllEmployees();
            return PartialView(model);
        }
        public ActionResult AddNew()
        {
            fillDepts();
            return PartialView(new EmployeeVM());
        }

        private void fillDepts()
        {
            List<DeptTable> depts = _repo.GetAllDepts();
            var list = new List<SelectListItem>();
            foreach (var dept in depts)
                list.Add(new SelectListItem { Text = dept.Name, Value = dept.Id.ToString() });
            ViewData["DeptList"] = list;
        }

        [HttpPost]
        public ActionResult AddNew(EmployeeVM vm)
        {
            fillDepts();
            if (ModelState.IsValid)
            {
                var emp = new Employee
                {
                    Address = vm.EmpAddress,
                    DeptId = vm.DeptId,
                    Name = vm.EmpName,
                    Salary = vm.EmpSalary
                };
                _repo.AddNewEmployee(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return PartialView(vm);
            }
        }

        public ActionResult Edit(string id)
        {
            List<DeptTable> depts = _repo.GetAllDepts();
            var list = new List<SelectListItem>();
            foreach (var dept in depts)
                list.Add(new SelectListItem { Text = dept.Name, Value = dept.Id.ToString() });
            ViewData["DeptList"] = list;
            var empId = int.Parse(id);
            var emp = _repo.GetAllEmployees().FirstOrDefault((e) => e.Id == empId);
            return PartialView(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            _repo.UpdateEmployee(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var empId = int.Parse(id);
            _repo.DeleteEmployee(empId);
            return RedirectToAction("Index");
        }
    }
}