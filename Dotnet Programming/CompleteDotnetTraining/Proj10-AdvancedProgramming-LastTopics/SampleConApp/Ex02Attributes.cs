using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//Attribute programming allows to provide optional properties or metadata that has some meaning to the system. They convey declarative information or metadata about UR code like methods, classes, properties etc. There are 2 types of attributes: System Attributes and Custom Attributes.
//All attributes are classes that is derived from a class called Attribute and will always have attribute as suffix. 
//Using Reflection, we can read the meta data of the Class and get the info about the attributes that are set to the defined block. 
namespace SampleConApp
{

    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class MyCustomAttribute : Attribute
    {
        private string _message = string.Empty;
        private string _access = string.Empty;

        public MyCustomAttribute(string access, string message)
        {
            _message = message;
            _access = access;
        }
        
        public string Message
        {
            get { return _message; }
        }

        public string Access => _access;
        
    }
    [Flags]
    enum Colors
    {
        Red = 1, Blue = 2, Green = 3, Yellow = 4, White = 5, Black
    }

   [MyCustom("For Class", "Represents the real time Customer")]
    class Customer
    {
        [MyCustom("Property", "Represents the Id of the Customer")]
        public int CustomerID { get; set; }
    }
    class Ex02Attributes
    {
        [Obsolete("This function is no longer recommended, U can try the new version called testingFunc")]
        static void testFunc()
        {
            Console.WriteLine("Test Func");
        }
        static void testingFunc() => Console.WriteLine("Test Func");

        static void readCustomAttributes()
        {
            //Class level Attributes..........
            Customer cst = new Customer();
            var attribute = cst.GetType().GetCustomAttribute<MyCustomAttribute>();
            if (attribute != null)
            {
                Console.WriteLine(attribute.Message);
                Console.WriteLine(attribute.Access);
            }
            else
                Console.WriteLine("Attribute not set for this class");
            //property level attributes
            var properties = cst.GetType().GetProperties();
            foreach (var prop in properties)
            {
                var propAttr = prop.GetCustomAttribute<MyCustomAttribute>();
                if (propAttr != null)
                {
                    Console.WriteLine("The Name of the Property: " + prop.Name);
                    Console.WriteLine("Attribute for the property: " + propAttr.GetType().Name);
                    Console.WriteLine($"Values of the Attribute:\nAccess : {propAttr.Access}\nMessage: {propAttr.Message}");
                    Console.WriteLine(propAttr.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            //testFunc();
            //testingFunc();
            readCustomAttributes();
            //Colors colors = Colors.Red | Colors.Green;
            //Console.WriteLine(colors.ToString());
        }
    }
}
