using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLayer;

namespace SampleFrameworksApp.Practical
{
    class MainUI
    {
        static IDataComponent component = null;
        static MainUI()
        {
            Console.WriteLine("Enter the Name of the Component as : List, ArrayList or Serialization");
            component = CustomerFactory.GetComponent(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            factoryTesting();
            //HashsetCollection collection = new HashsetCollection();
            //collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            //collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Mysore", BillAmount = 5600 });
            //collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Chennai", BillAmount = 5600 });
            //collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            //collection.AddNewCustomer(new Customer { CustomerId = 112, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            //Console.WriteLine("The Total no of Customers: " + collection.AllCustomers.Count);

            //foreach(var customer in collection.AllCustomers)
            //    Console.WriteLine(customer);
        }

        private static void factoryTesting()
        {
            //component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            //component.AddNewCustomer(new Customer { CustomerId = 112, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5000 });
            //component.AddNewCustomer(new Customer { CustomerId = 113, CustomerName = "Aravind", CustomerAddress = "Mangalore", BillAmount = 2600 });
            //component.AddNewCustomer(new Customer { CustomerId = 114, CustomerName = "Vinod", CustomerAddress = "Shimoga", BillAmount = 1600 });


            //component.UpdateCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Udupi", BillAmount = 5600 });
            var data = component.GetAllCustomers();
            foreach (Customer customer in data)
                Console.WriteLine(customer);
            component.DeleteCustomer(112);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
