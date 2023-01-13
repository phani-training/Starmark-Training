using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

 */
namespace SampleFrameworksApp
{
    class CustomerArray : IEnumerable
    {
        List<string> names = new List<string>();

        public void AddName(string name) => names.Add(name);

        public void DeleteName(int index)
        {
            if (index < names.Count)
                names.RemoveAt(index);
            else
                throw new Exception("Id is not there to delete");
        }
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                if (index < names.Count)
                    names[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in names)
                yield return item;
        }

        public int NamesCount => names.Count;
    }
    class Ex05CustomCollections
    {
        static void Main(string[] args)
        {
            CustomerArray array = new CustomerArray();
            array.AddName("Phaniraj");
            array.AddName("Ramesh");
            array.AddName("Rajeev");
            array.AddName("Bansal");

            for(int i =0; i < array.NamesCount; i++)
            {
                string old = array[i];
                array[i] = "Welcome to " + old; 
                Console.WriteLine(array[i]);
            }
            foreach (string name in array)
                Console.WriteLine(name);


        }
    }
}
