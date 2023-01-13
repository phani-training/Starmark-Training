using System;
using System.Collections.Generic;
using System.IO;
namespace SampleFrameworksApp.Practical
{
    class CSVFileIO
    {
        const string fileName = "../../Customers.csv";
        static void Main(string[] args)
        {
            var choice = Utilities.Prompt("What do U want to do today? Add or View. Press A for adding or V for Viewing");
            if (choice.ToUpper() == "A")
                writingExample();
            else if (choice.ToUpper() == "V")
                readingExample();
            else
                Console.WriteLine("Invalid Choice");
        }

        private static void readingExample()
        {
            List<Customer> allCustomers = new List<Customer>();
            var allLines = File.ReadAllLines(fileName);
            foreach(var line in allLines)
            {
                //Split each line based on Comma. 
                var words = line.Split(',');
                Customer cst = new Customer();
                cst.CustomerId = int.Parse(words[0]);
                cst.CustomerName = words[1];
                cst.CustomerAddress = words[2];
                cst.BillAmount = int.Parse(words[3]);
                allCustomers.Add(cst);
            }

            //2nd step..
            foreach(var cst in allCustomers)
                Console.WriteLine(cst.CustomerName);
        }

        private static void writingExample()
        {
            Customer cst = new Customer
            {
                CustomerId = Utilities.GetNumber("Enter the Customer ID"),
                CustomerName = Utilities.Prompt("Enter the Customer name"),
                CustomerAddress = Utilities.Prompt("Enter the Customer Address"),
                BillAmount = Utilities.GetNumber("Enter the Bill Amount")
            };
            File.AppendAllText(fileName, cst.ToString());
        }
    }
}