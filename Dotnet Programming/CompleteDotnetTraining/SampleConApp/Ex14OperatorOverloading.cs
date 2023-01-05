using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

        public static Employee operator + (Employee emp, int amount)
        {
            emp.EmpSalary += amount;
            return emp;
        }
        public static Employee operator -(Employee emp, int amount)
        {
            emp.EmpSalary -= amount;
            return emp;
        }

        public static bool operator > (Employee emp, int amount)
        {
            return emp.EmpSalary > amount;
        }

        public static bool operator <(Employee emp, int amount)
        {
            return emp.EmpSalary < amount;
        }
    }
    class Ex14OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EmpId = 111, EmpName ="TestName", EmpSalary = 56000
            };

            emp += 2000;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            Console.WriteLine(emp < 5000);
            Console.WriteLine(emp > 5000);
        }
    }
}
