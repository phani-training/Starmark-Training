using System;
/*
 * A Base class method can be modified in the derived class without altering the signature of the base method. 
 * In C#, only methods that are marked as virtual in the base class can be overriden in the derived class. 
 * The derived class will override the methods using override keyword, there by notifying the system that the method has been modified. 
 * static methods cannot have virtual or override keywords.
 * Method overriding promotes a concept called RUNTIME POLYMORPHISM.
 * U can change the business rules as per the new requirements.
 * base keyword is used to refer the immediate base class. 
 */
namespace SampleConApp
{
    class Business
    {
        public virtual void MakePayment(string payMode, double amount)
        {
            if(payMode == "CreditCard")
            {
                Console.WriteLine("Payment not accepted");
            }
            else
                Console.WriteLine("Payment accepted by {1} for Rs.{0}", amount, payMode);
        }
    }

    class TechBusiness : Business
    {
        public override void MakePayment(string payMode, double amount)
        {
            if (payMode == "Cheque")
            {
                Console.WriteLine("Payment is no longer accepted");
            }
            else
                Console.WriteLine("Payment accepted by {1} for Rs.{0}", amount, payMode);
        }
    }

    class BusinessFactory
    {
        public static Business GetObject(string arg)
        {
            if (arg.ToUpper() == "BUSINESS")
                return new Business();
            else if (arg.ToUpper() == "TECHBUSINESS")
                return new TechBusiness();
            else
                throw new Exception("This type of Business is not availabe with Us!!!");    

        }
    }
    class Ex10MethodOverriding
    {
        static void Main(string[] args)
        {
            //Business current = new Business();
            //current.MakePayment("CreditCard", 56000);

            //current = new TechBusiness();//Luskov substitution principle which states that a base type object can be substituted by any of the derived class instances. 
            //current.MakePayment("CreditCard", 70000);
            string bussType = Utilities.Prompt("Enter the Type of the Business U want to run?");
            Business component = BusinessFactory.GetObject(bussType);
            component.MakePayment("CreditCard", 5000);
        }
    }
}
