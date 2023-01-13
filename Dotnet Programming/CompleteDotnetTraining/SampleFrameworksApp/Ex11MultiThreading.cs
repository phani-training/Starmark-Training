using System;
using System.IO;
using System.Threading;

namespace SampleFrameworksApp
{
    class Ex11MultiThreading
    {
        static Thread thread;
        static int no = 0;
        static void threadFunc()
        {
            //Monitor.Enter(typeof(Ex11MultiThreading));
            lock (typeof(Ex11MultiThreading))//lock is keyword for Monitor
            {
                for (int i = 0; i < 10; i++)
                {
                    no += i;
                    var content = $"Thread Id with beep # {i} and count {no}";
                    Console.WriteLine(content);
                    Thread.Sleep(1000);
                }
            }
            //Monitor.Exit(typeof(Ex11MultiThreading));
        }
        static void LargeFuncWithParameters(object data)
        {
            //data is the filename that we want to read. 
            string filename = data.ToString();
            var contents = File.ReadAllLines(filename);
            foreach(var line in contents)
            {
                Thread.Sleep(1000);
                foreach(var ch in line.ToCharArray())
                {
                    Console.Write(ch);
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Complete set of records is read");
        }

        static void LargeFunction()
        {
            Console.WriteLine("The large function has started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Large Func is doing some job!!!");
                if(i == 5)
                    Thread.CurrentThread.Suspend();
            }
            Console.Clear();
            Console.WriteLine("The large function has completed");
           

        }

        static void defaultThreadOperation()
        {
            ThreadStart tFunc = new ThreadStart(LargeFunction);
           thread = new Thread(tFunc);
            thread.Start();

        }

        static void MultipleThreadsExample()
        {
            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);
            t1.Start();
            t2.Start();
        }

        static void ParameterizedThreadOperation()
        {
            ParameterizedThreadStart threadOp = new ParameterizedThreadStart(LargeFuncWithParameters);
            Thread th = new Thread(threadOp);
            th.IsBackground = true;
            th.Start("../../SampleNames.csv");
            th.Join();//Makes the calling thread wait for the child thread to complete.
        }
        static void mainOperation()
        {
            Console.WriteLine("Main is doing its job");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main is doing some job!!!");
            }
            Console.WriteLine("The Main has ended, UR App now Terminates!!!!");

        }
        static void Main(string[] args)
        {
            //defaultThreadOperation();
            //ParameterizedThreadOperation();
            //mainOperation();
            MultipleThreadsExample();
        }
    }
}
