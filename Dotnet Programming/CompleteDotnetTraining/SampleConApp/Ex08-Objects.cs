using System;
/*
 * C# is a language that is used in .NET which supports multiple languages.
 * There is a common base type for all languages called as System.Object.
 * C# has a keyword called object to it. 
 * All the types of .NET are derived from object. Everything is object. 
 * The derivation is implicit.
 * All variables of any kind can be stored as object. This is implicit. When a variable converts to an object, it is called as BOXING. It will box the data into the object.
 * object gives 4 functions that can be modified by the sub classes. 
 * GetType ->Gets the internal data type of the object that is stored.
 * ToString -> Gets the string representation of the object. 
 * GetHashCode -> Gets the unique ID of the object created in the CLR.
 * Equals(other) -> Gives a bool value that contains the logical equivalence of the object with the other
 */
namespace SampleConApp
{
    class Test
    {
        public string Content { get; set; }
    }
    class Ex08_Objects
    {
        static void Main(string[] args)
        {
            object data = 123;//boxed
            Console.WriteLine(data.GetHashCode());
            long copy = (int)data;//UNBOX....
            data = ++copy;
            Console.WriteLine(data.GetType().Name);
            data = "Sample Text";
            Console.WriteLine(data.GetType().Name);
            Console.WriteLine(data.GetHashCode());
            data = true;
            Console.WriteLine(data.GetType().Name);

            data = new string[] { "Data1", "Data2", "Data3" };
            Console.WriteLine(data.GetType().Name);


            //UNBOX IT..
            string[] contents = (string[])data;
            foreach (string content in contents) Console.WriteLine(content);
            Console.WriteLine("The data type: " + contents);

            Console.WriteLine("The string of the Test is " + new Test());

            Test t1 = new Test();
            Test t2 = t1;
            Console.WriteLine(t1.Equals(t2));

            object test = new Test();
            if(test is Test)//Check if it is of that type
            {
                Test ex = test as Test; //Unboxing for reference type
                ex.Content = "ASDfasdfas";
            }
        }
    }
}
