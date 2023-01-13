using System;
using System.Collections.Generic;

namespace SampleFrameworksApp
{
    using SampleFrameworksApp.Practical;


    class Ex03SortingData
    {
        static void Main()
        {
            sortingExampleOnMultiCriteria();
            //sortingExampleOnCustomer();
            //sortingExampleOnString();
        }

        private static void sortingExampleOnMultiCriteria()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                CustomerId = 1,
                CustomerName = "David",
                BillAmount = 500,
                CustomerAddress = "New York"
            });

            customers.Add(new Customer
            {
                CustomerId = 2,
                CustomerName = "Anna",
                BillAmount = 300,
                CustomerAddress = "Chicago"
            });

            customers.Add(new Customer
            {
                CustomerId = 3,
                CustomerName = "Jane",
                BillAmount = 250,
                CustomerAddress = "Washington"
            });

            customers.Add(new Customer
            {
                CustomerId = 4,
                CustomerName = "Tom",
                BillAmount = 100,
                CustomerAddress = "Yorkshire"
            });
            Console.WriteLine("Enter the Criteria to Sort");
            Array values = Enum.GetValues(typeof(Criteria));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Criteria selected = (Criteria)Enum.Parse(typeof(Criteria), Console.ReadLine());
            customers.Sort(new CustomerComparer(selected));
            foreach(var cst in customers)
                Console.WriteLine(cst);
        }

        private static void sortingExampleOnCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                CustomerId = 1, CustomerName = "David", BillAmount = 500, CustomerAddress= "New York"
            });

            customers.Add(new Customer
            {
                CustomerId = 2,
                CustomerName = "Anna",
                BillAmount = 300,
                CustomerAddress = "New York"
            });

            customers.Add(new Customer
            {
                CustomerId = 3,
                CustomerName = "Jane",
                BillAmount = 250,
                CustomerAddress = "New Jersy"
            });

            customers.Add(new Customer
            {
                CustomerId = 4,
                CustomerName = "Tom",
                BillAmount = 100,
                CustomerAddress = "Yorkshire"
            });

            customers.Sort();
            foreach(var cst in customers)
                Console.WriteLine(cst);
        }

        private static void sortingExampleOnString()
        {
            List<string> data = new List<string>();
            data.Add("David");
            data.Add("John");
            data.Add("Andrew");
            data.Add("Solomon");

            data.Sort();
            foreach (var value in data) Console.WriteLine(value);
        }
    }
}
