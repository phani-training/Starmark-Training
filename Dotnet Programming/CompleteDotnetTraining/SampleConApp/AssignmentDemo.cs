using System;
//Objective: to create array based on inputs given by the user
namespace SampleConApp
{
    class Utilities
    {
        internal static string Prompt(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int GetNumber(string question)
        {
            return int.Parse(Prompt(question));
        }
    }
    class AssignmentDemo
    {
        static void dynamicArrayExample()
        {
            int size = Utilities.GetNumber("Enter the Size of the Array");

            string typeName = Utilities.Prompt("Please enter the CTS Equilavent name for the type of the array that U want to create");
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);

            for (int i = 0; i < size; i++)
            {
                string enteredValue = Utilities.Prompt($"Enter the value of the type {type.Name}");
                object convertedValue = Convert.ChangeType(enteredValue, type);
                myArray.SetValue(convertedValue, i);
            }
            Console.WriteLine("All the values are set");
            foreach (object item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            dynamicArrayExample();
        }
    }
}
