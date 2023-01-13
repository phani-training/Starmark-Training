using System;
using System.Collections.Generic; 
/*
 - Generics are called as Type safe Collection Classes. 
 - Here the data is stored in the data structure as specific types, so no boxing or unboxing is required, performancewise it is faster, hense called as TYPE SAFE COLLECTIONS.
 - List is an extension of ArrayList, as both of them behave in the same manner. Both implement a same set of interfaces. IList<T> -> IList ->ICollection ->IEnumerable. 
 - List allows data to be added anywhere in the Collection. Add, Insert, InsertRange are the APIs
 - Find, FindAll are the methods used to search items in the collection. 
 - Remove and RemoveAt is used to remove Items in the Collection. 
 - Limitions of List is that it does allow duplicates. If U dont want duplicates, U should use HashSet<T>.
 - HashSet is similar to List but will not allow duplicates in the Collection.  HashSet<T> implements an interface called ISet<T>
 - Hashset checks for GetHashCode to see if the object is of the same type. If the same HashCode is available, then it checks the Logical Equivalence of the object with the Current one and then determines whether the object is same or not. 
 - Dictionary is a data structure to store the data in the form of key-value pairs. The key is unique and the value can be set to the key.
 - U have APIs to add, remove, items to the collection, U can also check for a key before inserting it. 
 - Add method adds a new pair to the collection, if the key already exists, it will throw an Exception. The ContainsKey method could be used to check for the keyentry before U wish to add the pair to the collection.
 - Queue is used to store the contents to the bottom of the collection, but the first entry only could be removed, U cannot remove intermediatory Items.
 */
namespace SampleFrameworksApp
{
    class Ex02GenericCollections
    {
        static void Main(string[] args)
        {
            //queueExample();
            //dictionaryExample();
            //hashSetExample();
            //listExample();
            sortedListExample();
        }

        private static void sortedListExample()
        {
            SortedList<string, long> contacts = new SortedList<string, long>();
            contacts.Add("Phaniraj", 9945205684);
            contacts.Add("Aravind", 9449184401);
            contacts.Add("Sumana", 7854876888);
            contacts.Add("Vasanth", 9945099876);
            contacts.Add("David", 9564555131);
            foreach(var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}-{contact.Value}");    
            }
        }

        private static void queueExample()
        {
            Queue<string> items = new Queue<string>();
            items.Enqueue("Item1");//Adds the item to the bottom of the collection. 
            items.Enqueue("Item2");
            items.Enqueue("Item3");
            items.Enqueue("Item4");
            items.Enqueue("Item5");
            items.Dequeue();//Always remove the first element in the collection. 
            foreach (var item in items) Console.WriteLine(item);
            Console.WriteLine("The total item in the queue: " + items.Count);

        }

        static Dictionary<string, string> users = new Dictionary<string, string>();
        private static void signUp()
        {
            RETRY:
                var uname = Utilities.Prompt("Enter the Username");
                var pwd = Utilities.Prompt("Enter the Password");
                if (users.ContainsKey(uname))
                {
                    Console.WriteLine("User already Registered");
                    goto RETRY;
                }
                users.Add(uname, pwd);
        }

        private static void signIn()
        {
        RETRY:
            var uname = Utilities.Prompt("Enter the Username");
            var pwd = Utilities.Prompt("Enter the Password");
            if (users.ContainsKey(uname))
            {
                if(users[uname] == pwd)
                {
                    Console.WriteLine("Welcome User!!!");
                }
                else
                {
                    Console.WriteLine("Password is invalid");
                    goto RETRY;
                }
            }
            else
            {
                Console.WriteLine("User does not exist");
                goto RETRY;
            }
        }

        private static void dictionaryExample()
        {
            do
            {
                var choice = Utilities.Prompt("Press 1 to Sign In(Login) and 2 to Sign Up(Register)");
                if(choice == "1")
                {
                    signIn();
                }else if(choice == "2")
                {
                    signUp();
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (true);
        }

        private static void hashSetExample()
        {
            HashSet<string> basket = new HashSet<string>();
            basket.Add("Mallika Mangoes");
            if (!basket.Add("Benisha Mangoes"))
            {
                Console.WriteLine("This already exists");
            }
            basket.Add("Ratnagiri Mangoes");
            basket.Add("Alphonso Mangoes");
            basket.Add("Raspuri Mangoes");
            Console.WriteLine("The Count of the basket is " + basket.Count);
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
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
