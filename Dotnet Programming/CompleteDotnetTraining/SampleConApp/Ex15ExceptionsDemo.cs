using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


/*
 * Exceptions in .NET are objects of a class called System.Exception. 
 * There are exceptions for all kinds of system related runtime issues. 
 * Exceptions in C# are handled using try....catch....finally block. 
 * try block contains the code that could raise an Exception.
 * catch block can handle those exceptions that are thrown by the system or the Application as objects of class derived from System.Exception
 * finally block is more like code cleaning that is executed on all the conditions. 
 * Exceptions are raised in .NET using throw keyword. 
 */
namespace SampleConApp
{

    public class EmpIDAlreadyExistsException : Exception
    {
        public EmpIDAlreadyExistsException() : this("Unknown Error")
        {

        }
        public EmpIDAlreadyExistsException(string message) : base(message)
        {
            Utilities.LogMessage(message);
        }
        public EmpIDAlreadyExistsException(string message, Exception inner) : base(message, inner)
        {

        }
      
    }
    class Ex15ExceptionsDemo
    {
        static void tryExample()
        {
        RETRY:
            Console.WriteLine("Enter a number to add");
            int no;
            try
            {
                no = int.Parse(Console.ReadLine());
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("input expected was a valid integer");
                Utilities.LogMessage(formEx.Message);
                throw new EmpIDAlreadyExistsException("EmpID already exists");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number should be b/w {0} to {1}", int.MinValue, int.MaxValue);
                Utilities.LogMessage(ex.Message);
                goto RETRY;
            }
            catch(EmpIDAlreadyExistsException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto RETRY;
            }
            Console.WriteLine("The entered value is " + no);
        }

        static void Main(string[] args)
        {
            try
            {
            tryExample();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
//            int no = Utilities.GetNumber("Please enter the Age as a number within the range of an integer");
        }
    }
}
