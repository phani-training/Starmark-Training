using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task is the way of doing operations on multiple Core. 
//There are many ways of creating tasks. U can use a Task factory to create a new Task and allow it to run. 
//Tasks always use thread Pool concept and they are background thread operations. 
namespace SampleConApp
{
    class Ex04AsyncProgramming
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task based Programming");
                }
            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread is working");
            }
            Console.ReadKey();
        }
    }
}
