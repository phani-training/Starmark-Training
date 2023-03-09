using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//.NET provides automatic memory management using Garbage Collection. It is a feature that handles the memory management when the Application is in short of memory. GC is the static class to represent Garbage Collector.
//C# Developers need not implement destructors for their classes. If their classes are using any unmanaged code(CODE THAT RUNS OUTSIDE THE CLR), then the programmers must deallocate the memory created by the code. To do that, we create functions that are to be invoked when their objects go out of scope. 
//The code written in Non-.NET Environment are not handled by CLR. So any memory allocated must be explicitly deallocated by the programmer himself. They create descructors and explicitly call them to deallocate the memory. 
//For .NET Programmers, they must call this deallocation function to release the memory created by the Unmanaged code. This is done by creating destructors or Dispose method.
//No Access specifiers for Destructors, they dont take any args. Destructors are internally called by the CLR, not explicitly by the programmer.
//Even though U can called GC.Collect to remove the unused references of the Application, but U cannot specify the specific object to be destroyed. 
namespace SampleConApp
{
    class SampleClass : IDisposable
    {
        private string name = string.Empty;
        public SampleClass(string name)
        {
            this.name = name;
            Console.WriteLine("Constructor for {0} object is created", this.name);
        }
        ~SampleClass()
        {
            Console.WriteLine("The object by name {0} is destroyed", name);
        }

        public void Dispose()
        {
            Console.WriteLine("The object by name {0} is destroyed using Dispose", name);
            GC.SuppressFinalize(this);//Destructor will not be called. 
        }
    }
    class Ex01MemoryManagement
    {
        
        static void createAndDestroyObjects()
        {
            for (int i = 0; i < 1000000; i++)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();//Makes the main thread wait till the objects are garbage collected
                using (SampleClass cls = new SampleClass("ClsName" + i))
                {

                }
            }
        }
        static void Main(string[] args)
        {
            createAndDestroyObjects();
            Console.WriteLine("Time to terminate this App");
        }
    }
}
