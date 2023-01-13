using System;
using SampleLib;
namespace SampleDataAccessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathComponent com = new MathComponent();
            Console.WriteLine(com.AddFunc(123, 234)); 
        }
    }
}
