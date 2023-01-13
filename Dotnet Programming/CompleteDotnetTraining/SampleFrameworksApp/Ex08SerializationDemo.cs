using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
/*

*/
namespace SampleFrameworksApp
{
    [Serializable]
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public override string ToString()
        {
            return $"{EmpName} from {EmpAddress}";
        }
    }

    class Ex08SerializationDemo
    {
        static void Main(string[] args)
        {
            //serializeExample();
            //deserializeExample();
            //xmlSerializeExample();
            //xmlDeserializeExample();
            //soapSerializeExample();
            soapDeserializeExample();
        }

        private static void soapDeserializeExample()
        {
            Employee emp = null;
            FileStream fs = new FileStream("EmpSoap.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter fm = new SoapFormatter();
            emp = fm.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(emp);
        }

        private static void soapSerializeExample()
        {
            Employee emp = new Employee
            {
                EmpID = 111,
                EmpAddress = "Bangalore",
                EmpName = "Phaniraj"
            };

            FileStream fs = new FileStream("EmpSoap.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter formatter = new SoapFormatter();
            formatter.Serialize(fs, emp);
            fs.Close();//Close the stream...
        }

        private static void xmlDeserializeExample()
        {
            Employee emp = null;
            FileStream fs = new FileStream("Emp.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer fm = new XmlSerializer(typeof(Employee));
            emp = fm.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(emp);
        }
        private static void xmlSerializeExample()
        {
            Employee emp = new Employee
            {
                EmpID = 111,
                EmpAddress = "Bangalore",
                EmpName = "Phaniraj"
            };

            FileStream fs = new FileStream("Emp.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer formatter = new XmlSerializer(typeof(Employee));
            formatter.Serialize(fs, emp);
            fs.Close();//Close the stream...
        }

        private static void deserializeExample()
        {
            Employee emp = null;
            FileStream fs = new FileStream("Emp.Bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            emp = fm.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(emp);
        }

        private static void serializeExample()
        {
            Employee emp = new Employee
            {
                EmpID = 111,
                EmpAddress = "Bangalore",
                EmpName = "Phaniraj"
            };

            FileStream fs = new FileStream("Emp.Bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, emp);
            fs.Close();//Close the stream...
        }
    }
}
