using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleRestApi.Models;
using SampleRestApi.ViewModels;

namespace SampleRestApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<EmployeeVM> GetEmployees()
        {
            var context = new ProductEntites();
            var empList = from emp in context.Employees
                          select new EmployeeVM
                          {
                              Address = emp.Address,
                              DeptId = emp.DeptId,
                              Id = emp.Id,
                              Name = emp.Name,
                              Salary = emp.Salary
                          };
            return empList.ToList();
        }

        [Route("api/Depts")]
        public List<Dept> GetDepts()
        {
            var context = new ProductEntites();
            var deptList = context.DeptTables.Select(d => new Dept
            {
                Id = d.Id, Name = d.Name, Location = d.Location
            }).ToList();
            return deptList;
        }


    }
}
