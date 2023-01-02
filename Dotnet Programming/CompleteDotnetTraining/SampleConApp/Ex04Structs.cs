using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    struct Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
        //U cannot create Parameterless Constructor for structs. .NET gives one default constructor. 
        public Employee(int id, string name, string address, double salary)
        {
            EmpId = id;
            EmpName = name;
            EmpAddress = address;
            EmpSalary = salary;
        }

        public string GetDetails()
        {
            return $"The Name: {EmpName} from {EmpAddress} with Salary {EmpSalary:c}";
        }
    }
    class Ex04Structs
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee { EmpId = 123, EmpAddress = "Bangalore", EmpName = "Phaniraj", EmpSalary = 56000 };//Object Initialization Syntax from C# 4.0..
            Employee emp = new Employee(123, "Phaniraj", "Bangalore", 67000);
            Console.WriteLine(emp.GetDetails());
        }
    }
}
