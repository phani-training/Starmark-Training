using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class BookArrayHelper
    {
        private static Book[] array = null;

        public static Book[] AddBook(Book book)
        {
            if(array == null)
            {
                array = new Book[1];
                array[0] = book.DeepCopy(book);
            }
            else
            {
                Array copy = array.Clone() as Array;
                array = new Book[copy.Length + 1];
                Array.Copy(copy, array, copy.Length);
                array[array.Length - 1] = book.DeepCopy(book);
            }
            return array;
        }

        public static Book [] RemoveBook(Book[] array, int index)
        {
            Book[] destination = new Book[array.Length - 1];
            if (index > 0)
                Array.Copy(array, 0, destination, 0, index);

            if(index < array.Length - 1)
            {
                Array.Copy(array, index + 1, destination, index, array.Length
                     - index - 1);
            }
            return destination;
        }
    }
}
