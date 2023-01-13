using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
/*
 * Reading and Writing xml data could be done in many ways in .NET
 * U can convert UR data to DataSet and write to xml
 * U can use XmlReader which reads like a Parser and based on the Node type U can perform UR operations. 
 * U can use Xml Serialization to achieve the same.
 * U can use XLNQ, an extension of LINQ to perform read-write operations on Xml file. 
 * This Example uses the DataSet's WriteXml and GetXml to write and read the xml data. 
 */
namespace SampleFrameworksApp
{
    class Ex07XmlFileIODemo
    {
        static Customer[] getAllCustomers(string fileName)
        {
            List<Customer> allCustomers = new List<Customer>();
            var allLines = File.ReadAllLines(fileName);
            foreach (var line in allLines)
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
            return allCustomers.ToArray();
        }

        static void writeToxml(Customer[] data, string fileName)
        {
            DataTable table = new DataTable("Customer");
            table.Columns.Add("CustomerId", typeof(int));
            table.Columns.Add("CustomerName", typeof(string));
            table.Columns.Add("CustomerAddress", typeof(string));
            table.Columns.Add("BillAmount", typeof(int));
            //Populate the data into the Table....
            foreach (var cst in data)
            {
                DataRow row = table.NewRow();
                row[0] = cst.CustomerId;
                row[1] = cst.CustomerName;
                row[2] = cst.CustomerAddress;
                row[3] = cst.BillAmount;
                table.Rows.Add(row);
            }
            table.AcceptChanges();
            DataSet ds = new DataSet("Customers");
            ds.Tables.Add(table);
            ds.WriteXml(fileName);
            
        }
        static void Main(string[] args)
        {
            var data = getAllCustomers("../../Customers.csv");
            writeToxml(data, "../../Customers.xml");
            //Console.WriteLine(ds.GetXml());
           
        }
    }
}
