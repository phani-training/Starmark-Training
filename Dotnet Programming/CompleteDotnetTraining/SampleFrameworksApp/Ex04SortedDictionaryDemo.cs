using System;
using System.Collections.Generic;
/*
 * Sort the data based on the Key value using the default comparer. Very similar to SortedList where Sorted List can have its own IComparer Implementation. 
 */
namespace SampleFrameworksApp
{
    class Ex04SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phoneNos = new SortedDictionary<string, long>();
            phoneNos.Add("Phaniraj", 9945205684);
            phoneNos.Add("Ramesh", 9449184401);
            phoneNos.Add("Gopal", 9845022331);
            phoneNos.Add("David", 9447855433);
            phoneNos.Add("Jenny", 9998765568);
            phoneNos.Add("Aravind", 7768883343);

            foreach(var pair in phoneNos)
                Console.WriteLine(pair.Key);
        }
    }
}
