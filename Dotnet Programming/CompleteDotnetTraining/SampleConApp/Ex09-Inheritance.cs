using System;
/*
 * C# does not support private inheritance. 
 * U cannot inherit from multiple classes at the same level. It does not support multiple inheritance. However, U can have multilevel Inheritance. 
 * U can modify the methods of the base class with the same signature back in the derived class using a concept called method overriding. 
 */
namespace SampleConApp
{
    class Account
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; protected set; } = 5000;
    }

    class SBAccount : Account
    {
        public void Credit(int amount) => Balance += amount;

        public void Debit(int amount) => Balance -= amount;

    }

    class RDAccount : Account
    {
        int amount = 5000;
        public void MakePayment()
        {
            Console.WriteLine($"Payment of Rs. {amount} is done");
            Balance += amount;
        }
    }



    class BaseClass
    {
        public void BaseFunc() => Console.WriteLine("Base func");
    }

    class DerivedClass :  BaseClass
    {
        public void DerivedFunc() => Console.WriteLine("Derived Func");
    }
    

    class Ex09_Inheritance
    {
        static void Main(string[] args)
        {
            BaseClass cls = new BaseClass();
            cls.BaseFunc();

            DerivedClass cls2 = new DerivedClass();
            cls2.DerivedFunc();
            cls2.BaseFunc();

            SBAccount acc = new SBAccount { AccountName = "testName", AccountNo = 123 };
            acc.Credit(45000);
            acc.Debit(5000);
            Console.WriteLine("The Balance : " + acc.Balance);
        }
    }
}
