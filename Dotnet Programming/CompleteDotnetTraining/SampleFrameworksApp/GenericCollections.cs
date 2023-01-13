using System;
using System.Collections.Generic; 
/*
 * Generics are called as Type safe Collection Classes. 
 * Here the data is stored in the data structure as specific types, so no boxing or unboxing is required, performancewise it is faster, hense called as TYPE SAFE COLLECTIONS.
 * List is an extension of ArrayList, as both of them behave in the same manner. Both implement a same set of interfaces. IList<T> -> IList ->ICollection ->IEnumerable. 
 */
namespace SampleFrameworksApp
{
    class Ex02GenericCollections
    {
        static void Main(string[] args)
        {
            listExample();
        }

        private static void listExample()
        {
            string[] oldValues = { "Kiwi Fruit", "Pine Apples", "Oranges", "Bananas" };
            List<string> fruits = new List<string>(oldValues);
            fruits.Add("Apples");
            fruits.Add("Big Apples");
            fruits.Add("Custard Apples");
            fruits.Add("Ooty Apples");
            fruits.Add("Green Apples");
            fruits.Insert(3, "Mangoes");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
