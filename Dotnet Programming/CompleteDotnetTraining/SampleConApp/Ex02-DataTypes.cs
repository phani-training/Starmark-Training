using System;

namespace SampleConApp
{
    class Ex02_DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The range of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and {long.MaxValue}");
            int iValue = 123;
            long lValue = long.MaxValue; //Implicit Casting.
            checked
            {
                //iValue = (int)(lValue);//Explicit Casting...
            }
            iValue = (int)(lValue);//Explicit Casting...

            Console.WriteLine("The Int value now has: " + iValue);
        }
    }
}
