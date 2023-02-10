using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleRestApi.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
    }

    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}