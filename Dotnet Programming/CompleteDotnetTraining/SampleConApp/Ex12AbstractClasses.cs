using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Abstract class is one that contains one or more abstract methods in it. 
 * An Abstract method is a function that does not have an implementation. 
 * The method must be implemented by the derived class.
 * The class is incomplete, U cannot instantiate the class. 
 * An abstract class can have normal methods as well as virtual methods in it. 
 * If a class is derived from an abstract class, it must implement all the abstract methods of the base class, else even this class should be marked as abstract. 
 */
namespace SampleConApp
{

    abstract class Account
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; private set; } = 5000;
        public void Credit(int amount) => Balance += amount;
        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        //override is used to implement the abstract method. 
        public override void CalculateInterest()
        {
            var pricipal = Balance;
            var time = 0.25;
            var rate = 0.05;
            var interest = pricipal * time * rate;
            Credit((int)interest);
        }
    }
    class Ex12AbstractClasses
    {
        static void Main(string[] args)
        {
            Account acc = AccountFactory.CreateAccount("SB");//Create this class 
            acc.AccNo = 123;
            acc.Name = "Test Name";
            acc.Credit(56000);
            acc.CalculateInterest();
            Console.WriteLine("The current balance is " + acc.Balance);
        }
    }
}
