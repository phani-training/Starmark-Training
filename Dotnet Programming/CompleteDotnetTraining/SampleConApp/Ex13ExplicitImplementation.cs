using System;

namespace SampleConApp
{
    interface IExample
    {
        void Create();
    }

    interface ISimple
    {
        void Create();
    }

    class SimpleExample : IExample, ISimple
    {
        public void Create()
        {
            Console.WriteLine("General Implementation");
        }
        
        void ISimple.Create() => Console.WriteLine("Simple version of Create");
        void IExample.Create() => Console.WriteLine("Example version of Create");
    }
    class Ex13ExplicitImplementation
    {
        static void Main(string[] args)
        {
            SimpleExample simEx = new SimpleExample();
            simEx.Create();

            IExample ex = new SimpleExample();
            ex.Create();

            ISimple sim = new SimpleExample();
            sim.Create();
        }
    }
}
