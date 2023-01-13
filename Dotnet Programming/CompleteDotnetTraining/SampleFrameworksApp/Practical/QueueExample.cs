using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SampleFrameworksApp
{
    class QueueExample
    {
        private Queue<string> _recentList = new Queue<string>();

        public void ViewItem(string item)
        {
            if (_recentList.Count == 3) _recentList.Dequeue();
            _recentList.Enqueue(item);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(item);
            Thread.Sleep(4000);
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Our recently viewed Items:");//queue does not have reverse.

            var data = _recentList.Reverse();//Use System.Linq to get this API....
            foreach (var element in data) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("---------------");
                Console.WriteLine(element);
                Console.WriteLine("---------------");
                Console.ResetColor();
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            QueueExample ex = new QueueExample();
            do
            {
                var input = Utilities.Prompt("Enter the Item that U want to see");
                ex.ViewItem(input);
            } while (true);
        }
    }
}