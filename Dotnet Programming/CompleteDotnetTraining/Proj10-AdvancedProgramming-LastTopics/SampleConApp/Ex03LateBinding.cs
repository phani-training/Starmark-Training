using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
//Do not reference the CSharpLib Project. 
namespace SampleConApp
{
    class Ex03LateBinding
    {
        private static readonly string dllFile = ConfigurationManager.AppSettings["dllFile"];
        private static Type selectedType = null;//For the selected Type
        private static object instance = null;//For the object creation
        private static MethodInfo selectedMethod = null;//For UR Method to invoke
        private static object[] parameterValues = null;
        static void getTypeReference()
        {
            var assembly = Assembly.LoadFile(dllFile);
            if (assembly == null)
            {
                Console.WriteLine("Failed to load the DLL into the process");
                return;
            }
            ////////////Get the Classes in that assembly//////////////////
            var types = assembly.GetTypes();
            foreach (var type in types)
                Console.WriteLine(type.FullName);
            Console.WriteLine("Select the Class as FullName that U want to work with");
            var name = Console.ReadLine();
            selectedType = assembly.GetType(name, false, true);
        }

        static void getMethodToInvoke()
        {
            if (selectedType == null)
            {
                Console.WriteLine("This type is not supported in this Assembly");
                return;
            }
            var methods = selectedType.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Name: {method.Name}, Return Type: {method.ReturnType.Name}, Paramters List: ");
                var parameters = method.GetParameters();
                foreach (var @param in parameters)
                {
                    var direction = param.IsOut == true ? "Out" : "In";
                    Console.WriteLine($"The Parameter Name: {param.Name}\nThe Data Type: {param.ParameterType.Name}, Direction: {direction}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Please select the method to invoke");
            var methodName = Console.ReadLine();
            selectedMethod= selectedType.GetMethod(methodName);
            
        }

        static void setValuesToParameters()
        {
            if(selectedMethod == null)
            {
                Console.WriteLine("This method is not supported by our Class");
                return;
            }
            var parameters = selectedMethod.GetParameters();
            parameterValues = new object[parameters.Length];
            int index = 0;
            foreach(var @param in parameters)
            {
                Console.WriteLine($"Enter the value for the parameter {param.Name} of the data type {param.ParameterType.Name}");
                var strValue =  Console.ReadLine();
                parameterValues[index] = Convert.ChangeType(strValue, param.ParameterType);
                index++;
            }
            //create the instance of the Class. 
            instance =  Activator.CreateInstance(selectedType);
            var result = selectedMethod.Invoke(instance, parameterValues);
            Console.WriteLine("The result of this operation is " + result);
        }
        static void Main(string[] args)
        {
            getTypeReference();
            getMethodToInvoke();
            setValuesToParameters();
        }
    }
}
