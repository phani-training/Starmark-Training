using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
namespace SampleDataAccessApp
{
    class XLinqDemo
    {
        const string FILENAME = "../../SampleData.xml";
        static void Main(string[] args)
        {
            //simpleXmlDemo(); //Demo on XElement.....
            //var data = DataComponent.AllRecords;//Get the List<Employee> from file....
            //convertToXml(data);//Convert the List<Employee> into Xml and save the file 


            //displaynames();
            //displayNamesAndAddresses();
            //insertRecord("Mallikarjun", "Gulbarga", 60000, 4);
            insertRecordAt(67, "Chetan", "Kolar", 67000, 3);
        }

        private static void insertRecordAt(int id, string name, string address, int salary, int deptId)
        {
            throw new NotImplementedException();
        }

        private static void insertRecord(string name, string address, int salary, int deptId)
        {
            //Insert the record to the last...
            var doc = XDocument.Load(FILENAME);
            var lastEmp = (from element in doc.Descendants("Employee")
                           select element).Last();
            var lastId = int.Parse(lastEmp.Element("EmpId").Value);
            lastId++;
            var newRec = new XElement("Employee",
                                            new XElement("EmpId", lastId),
                                            new XElement("EmpName", name),
                                            new XElement("EmpAddress", address),
                                            new XElement("EmpSalary", salary),
                                            new XElement("DeptId", deptId)
                                        );
            lastEmp.AddAfterSelf(newRec);
            doc.Save(FILENAME);
        }

        private static void displayNamesAndAddresses()
        {
            XDocument doc = XDocument.Load(FILENAME);//Load the Xml Doc
            var records = from element in doc.Descendants("Employee")
                          select new
                          {
                              Name = element.Element("EmpName").Value,
                              Address = element.Element("EmpAddress").Value
                          };
            foreach (var rec in records) Console.WriteLine(rec);
        }

        private static void displaynames()
        {
            XDocument doc = XDocument.Load(FILENAME);
            var records = from element in doc.Descendants("Employee")
                          select element.Element("EmpName");
            foreach(var rec in records)
                Console.WriteLine(rec);//try using Value property.....
        }

        private static void convertToXml(List<Employee> data)
        {
            var root = new XElement("Employees", from emp in data
                                        select new XElement("Employee",
                                            new XElement("EmpId", emp.EmpId),
                                            new XElement("EmpName", emp.EmpName),
                                            new XElement("EmpAddress", emp.EmpCity),
                                            new XElement("EmpSalary", emp.EmpSalary),
                                            new XElement("DeptId", emp.DeptId)
                                        )
                                    );
            root.Save(FILENAME);
        }

        private static void simpleXmlDemo()
        {
            XElement root = new XElement("Employees",
                new XElement("Employee",
                new XAttribute("Gender", "Male"),
                new XElement("EmpId", 123),
                new XElement("EmpName", "Phaniraj"),
                new XElement("EmpAddress", "Bangalore"),
                new XElement("EmpSalary", 50000),
                new XElement("DeptId", 3)
            ));
            Console.WriteLine(root);
            root.Save(FILENAME);
        }
    }
}