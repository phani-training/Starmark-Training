using LoginApp.DataComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.DataRepos
{
    public interface IUserModule
    {
        CustomerTable ValidateUser(string emailAddress, string password);//Sign In
        void RegisterCustomer(CustomerTable customer);//Sign up
        void UpdateCustomer(CustomerTable customer);//Modify Password
    }
    public class UserModule : IUserModule
    {
        private bool isValidEmail(string emailAddress)
        {
            var context = new Entities();
            var rec = context.CustomerTables.SingleOrDefault(c => c.CustomerEmail == emailAddress);
            return rec == null;
        }

        public void RegisterCustomer(CustomerTable customer)
        {
            var context = new Entities();
            if (isValidEmail(customer.CustomerEmail))
            {
                context.CustomerTables.Add(customer);
                context.SaveChanges();
            }
            else
                throw new Exception("Customer is already registered, please click on Forgot Password");
        }

        public void UpdateCustomer(CustomerTable customer)
        {
            throw new NotImplementedException("Not implemented in the current Version");
        }

        public CustomerTable ValidateUser(string emailAddress, string password)
        {
            var context = new Entities();
            var customer = context.CustomerTables.SingleOrDefault(c => c.CustomerEmail == emailAddress && c.Password == password);
            if (customer == null)
                throw new Exception("Login Failed");
            return customer;
        }
    }
}