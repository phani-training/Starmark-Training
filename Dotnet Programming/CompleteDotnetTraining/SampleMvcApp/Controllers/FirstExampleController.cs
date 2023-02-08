using SampleMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//URController->Controller->ControllerBase->IController
namespace SampleMvcApp.Controllers
{
    public class FirstExampleController : Controller
    {
        public string Helloworld() => "Hai from MVC";

        public double GetNumber(string v1, string v2)
        {
            var first = double.Parse(v1);
            var second = double.Parse(v2);
            return first + second;
        }

        public ViewResult DisplayEmployee()
        {
            var employee = new Employee
            {
                EmployeeId = 123, EmployeeName = "Sanjay", EmployeeEmail ="sanjay@gmail.com", EmployeeSalary = 67000
            };
            return View(employee);//View must be injected with the model that U want to show
        }
    }
}