using System;
/*
 * When a base class's non virtual function is reimplemented in the derived class, the object of the base class will hide the implementation of the derived class.
 */
namespace SampleConApp
{
    class BaseClass
    {
        public void BaseFunc() => Console.WriteLine("Base func is implemented");
    }

    class DerivedClass : BaseClass
    {
        public void DerivedFunc() => Console.WriteLine("Derived func");
        public new void BaseFunc() => Console.WriteLine("Base func implemented in Derived");     
    }
    class Ex11_MethodHiding
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedClass();
            //instance.DerivedFunc();It does not work due to slicing.
            instance.BaseFunc();
            if(instance is DerivedClass)//To get the sliced methods, U should cast to the type
            {
                DerivedClass copy = instance as DerivedClass;
                copy.BaseFunc();
            }
        }
    }
}
