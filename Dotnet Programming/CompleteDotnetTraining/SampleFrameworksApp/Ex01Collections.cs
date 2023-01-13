using System;
using System.Collections;
/*
 * Collections are a bunch of classes created to resolve the issues with Arrays. 
 * All the limitations of the Arrays are resolved using the Collection Classes. 
 * Collection classes are available in 2 variations: Generic and NonGeneric. 
 * NonGeneric are the oldest form of collections, almost obselete but is still available in the .NET Frameworks for backward compatibility and certain scenarios. 
 * Generics came in .NET 2.0.(2005).
 * System.Collections is the namespace for the classes related to Non Generic Collections.
 * Data is stored in Collections as objects, so the data will be boxed and unboxed every time U R accessing it, there by reducing the performance of the Collection. It is sometimes unsafe as U can store any kind of data in it.  
 * Dictionary stores the data in the form of key-value pairs very similar to MAP of STL. 
 */
namespace SampleFrameworksApp
{
    class Ex01Collections
    {
        static void Main(string[] args)
        {
            //arrayListExample();
            hashTableExample();
        }

        private static void hashTableExample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("SampleName", "Example123");//Adds the new key-value pair to the Collection
            hashtable["TestName"] = "Test123";//It the key already exists, it modifies the value, else adds a new key-value pair. 
            foreach (DictionaryEntry pair in hashtable)
            {
                Console.WriteLine("{0}-{1}", pair.Key, pair.Value);
            }
            //Iterating thru keys.........
            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);//Display the values
            }
            
        }

        private static void arrayListExample()
        {
            ArrayList list = new ArrayList();//blank list of items. 
            list.Add("Apples");
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("Bananas");
            list.Remove("Bananas");
            list.Insert(2, "Kiwi Fruit");
            list.RemoveAt(1);
            Console.WriteLine("No of elements: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
