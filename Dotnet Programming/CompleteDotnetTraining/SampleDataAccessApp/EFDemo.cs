using System.Xml.Linq;
using System.Linq;
namespace SampleDataAccessApp
{
    class EFDemo
    {
        static void bulkUpload()
        {
            var doc = XDocument.Load("../../SampleData.xml");//Load the doc
            var collection = from element in doc.Descendants("Employee")
                             select new tblEmployee
                             {
                                 DeptId = int.Parse(element.Element("DeptId").Value),
                                 EmpAddress = element.Element("EmpAddress").Value,
                                 EmpName = element.Element("EmpName").Value,
                                 EmpId = int.Parse(element.Element("EmpId").Value),
                                 EmpSalary = int.Parse(element.Element("EmpSalary").Value)
                             };//Convert each Employee element to tblEmployee objects

            var context = new MyDBEntities();//Create the DBContext instance
            context.tblEmployees.AddRange(collection);//AddRange for bulk insertion
            context.SaveChanges();//Commit to the database.
        }
        static void Main(string[] args)
        {
            bulkUpload();
            readRecords();
        }

        private static void readRecords()
        {
            var context = new MyDBEntities();//Connectivity....
            foreach (var row in context.tblEmployees)//Read the rows of the tblEmployees
            {
                System.Console.WriteLine(row.EmpName);
            }
        }
    }
}