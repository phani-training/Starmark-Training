using System;
/*
 * Sealed classes are created to ensure that the class can only be used as an object, but cannot e inherited.
 * Sealed methods are created to ensure that the method should not be overriden further or modified by the derived classes. 
 * Sealed methods can be placed in the normal classes. sealed methods must have override keyword in them. It implies only virtual methods defined in their base classes can be modified and sealed in the current class, so that u r allowing to modify the base version and should not extend the method further. 
 * String is a sealed class. U cannot inherit another class from it.
 */
namespace SampleConApp
{
    class SuperBaseClass
    {
        public virtual void SimpleMethod() => Console.WriteLine("Base version");
    }
    class Concreteclass : SuperBaseClass
    {
        public sealed override void SimpleMethod() => Console.WriteLine("Simple method from the sealed class");
    }

    class SubConcreteClass : Concreteclass
    {
        //Method hiding as the base version of this method is sealed...
        public new void SimpleMethod() => Console.WriteLine("Simple method's new implemention from the Derived class");
    }

    //Gets an error as sealed classes cannot be inherited. 
    //class ImplementorClass : Concreteclass
    //{

    //}

    class Ex17SealedClasses
    {
        static void Main(string[] args)
        {
            SuperBaseClass cls = new SuperBaseClass();
            cls.SimpleMethod();

            cls = new Concreteclass();
            cls.SimpleMethod();

            cls = new SubConcreteClass();
            if(cls is SubConcreteClass)
            {
                var copy = cls as SubConcreteClass;
                copy.SimpleMethod();
            }
//            cls.SimpleMethod();//Base versin...
        }
    }

    
}
