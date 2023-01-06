using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * static classes are those that have a modifier static at the class declaration.
 * These classes cannot have instance methods, they are refered directly by their classname.
 * Static classes have only static members, so there will be no intention to create an instance of the same. So static keyword at the class level restricts the user from creating an instance of the class.
 * Static classes can have constructors using static keyword. Normal classes also have static constructors to inject dependencies to the static members of the class. 
 * Static constructors cannot be parameterized. U cannot access specifier to it. 
 * It is implicitly invoked by the .NET when the first reference of any static member of the class is made.
 * It is called once and only once for the execution of the program.
 */
namespace SampleConApp
{
    class Example
    {
        internal static int value;
        public Example() => Console.WriteLine("Instance Constructor");

        static Example()
        {
            value = 1000;
            Console.WriteLine("Static Constructor");
        }
    }
    static class SingletonClass
    {
        public static void StaticMethod() => Console.WriteLine("Static method called");
    }
    class Ex18StaticConstructors
    {
        static void Main(string[] args)
        {
            //Example ex = new Example();
            //ex = new Example();
            //ex = new Example();
            //ex = new Example();
            //ex = new Example();
            //ex = new Example();
            Example.value = 123;
        }
    }
}

