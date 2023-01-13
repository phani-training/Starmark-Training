using System;
using System.Threading;

namespace SampleFrameworksApp
{
    class Ex12ThreadPoolExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Thread Id " + Thread.CurrentThread.ManagedThreadId);
            int threadCount, maxCount, minCount;
            ThreadPool.GetMaxThreads(out threadCount, out maxCount);
            Console.WriteLine($"The Max Threads available: {threadCount}");
            ThreadPool.QueueUserWorkItem(new WaitCallback((obj) =>
            {
                Console.WriteLine("The Thread Id " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(Thread.CurrentThread.IsBackground);
                for (int i = 0; i < 10; i++)
                {
                    var content = $"Thread Id with beep # {i}";
                    Console.WriteLine(content);
                    Thread.Sleep(1000);
                }
            }));
            //for (int i = 0; i < 10; i++)
            //{
            //    var content = $"Main Thread with beep # {i}";
            //    Console.WriteLine(content);
            //    Thread.Sleep(1000);
            //}
            Console.ReadKey();
        }
    }
}
