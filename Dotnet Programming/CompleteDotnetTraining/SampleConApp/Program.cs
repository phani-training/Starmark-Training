using System;
using System.Diagnostics;

namespace SampleConApp
{
    class Ex01FirstProgram
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the Salary");
            string salary = Console.ReadLine();
            Debug.WriteLine("The Entered address " + address);
            Console.WriteLine("The input results: \nName: " + name + "\nAddress: " + address + "\nSalary: " + salary);
            Console.WriteLine($"The Name is {name} from {address} earning a Salary of Rs. {salary}");//C# 6.0 onwards..
        }
    }
}
