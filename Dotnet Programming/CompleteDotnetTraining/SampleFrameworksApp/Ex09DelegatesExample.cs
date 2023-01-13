using System;
/*
 - Delegates are like Function Pointers of C++. They are reference types to the methods. 
 - We also call them as functional Types. 
 - We use delegates to pass Functions as parameters to the function declaration.
 - Delegate signature will be like a function with return types and parameters. 
 - Functions that use delegate can refer them in the form of parameters. 
 - Callers of these functions pass arguments to the function as instances of the delegate.
 - The Delegate instance(object) will point to the actual function that matches the signature of the delegate.
 - Anonymouse methods and Lambda Expressions are improvisations over the usage of delegate instances in C#. (C# 2.0)
 - Anonymous methods use delegate keyword to define the function. The function will be like an argument to the function that has the delegate as parameter.(
 - Lambda Expressions are improvization on the Anonymous methods.(C# 3.5) 
 - If A delegate instance is pointing to multiple functions, then it is called as MULTICAST DELETE. It creates an array of delegate instances in it in the form of invocationList which can be acquired using a method GetInvocationList.
 - Methods can be added to the delegate instance using += operator and can be removed using -= operator. 
 - System.Delegate is a .NET Class that gives the type info about the delegate Instance that U R using.  
 */
namespace SampleFrameworksApp
{
    delegate double ArithematicOperation(double v1, double v2);

    class MathComponent
    {
        public static void PerformOperation(ArithematicOperation operation)
        {
            var v1 = double.Parse(Utilities.Prompt("Enter the First Value"));
            var v2 = double.Parse(Utilities.Prompt("Enter the Second Value"));
            Delegate[] allOperations = operation.GetInvocationList();
            foreach(Delegate func in allOperations)
            {
                Console.WriteLine(func.Method.Name);
                Console.WriteLine("The result of this Operation is " + func.DynamicInvoke(v1, v2));
            }
        }
    }
    class Ex09DelegatesExample
    {
        static double addFunc(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        static double subFunc(double v1, double v2) => v1 - v2;
        
        static void singleCastDelegate()
        {
            MathComponent.PerformOperation(new ArithematicOperation(addFunc));
            MathComponent.PerformOperation(delegate (double v2, double v1)
            {
                return v2 - v1;
            });//Anonymous Methods of C# 2.0

            MathComponent.PerformOperation((a, b) => a * b);
        }
        static void Main(string[] args)
        {
            singleCastDelegate();
            multicastDelegateExample();
        }

        private static void multicastDelegateExample()
        {
            ArithematicOperation operations = new ArithematicOperation(addFunc);

            operations += new ArithematicOperation(subFunc);

            operations += new ArithematicOperation(delegate (double v1, double v2)
            {
                return v1 * v2;
            });

            operations += new ArithematicOperation(delegate (double v1, double v2)
            {
                return v1 / v2;
            });

            MathComponent.PerformOperation(operations);
        }
    }
}
