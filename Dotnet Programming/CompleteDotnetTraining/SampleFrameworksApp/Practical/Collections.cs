using SampleFrameworksApp.Practical;
using System;
using System.Collections;
using UtilitiesLayer;

namespace DataLayer
{
    interface IDataComponent
    {
        void AddNewCustomer(Customer cst);
        void UpdateCustomer(Customer cst);
        Customer[] GetAllCustomers();
        void DeleteCustomer(int id);
    }
    class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int BillAmount { get; set; }
    }
    class CustomerDatabase : IDataComponent
    {
        public CustomerDatabase()
        {
            Console.WriteLine("Array List is being used");
        }
        private ArrayList _listOfCustomers = new ArrayList();//UR Array is replaced by ArrayList. 
        public void AddNewCustomer(Customer cst)
        {

            _listOfCustomers.Add(cst);//the data is boxed and then added to the list
        }

        public void DeleteCustomer(int id)
        {
            foreach(var cst in _listOfCustomers)
            {
                if(cst is Customer)
                {
                    var unBoxed = cst as Customer;
                    if(unBoxed.CustomerId == id)
                    {
                        _listOfCustomers.Remove(unBoxed);
                        return;
                    }
                }
            }
            throw new CustomerException("Customer not found to delete");
        }

        public Customer[] GetAllCustomers()
        {
            Customer[] array = new Customer[_listOfCustomers.Count];
            for (int i = 0; i < _listOfCustomers.Count; i++)
            {
                if(_listOfCustomers[i] is Customer)
                    array[i] = _listOfCustomers[i] as Customer;//UNBOXING...
            }
            return array;
        }

        public void UpdateCustomer(Customer customer)
        {
            foreach (var cst in _listOfCustomers)
            {
                if (cst is Customer)//Check if the object is of the type Customer
                {
                    var unBoxed = cst as Customer;
                    if (unBoxed.CustomerId == customer.CustomerId)
                    {
                        unBoxed.CustomerAddress = customer.CustomerAddress;
                        unBoxed.CustomerName = customer.CustomerName;
                        unBoxed.BillAmount = customer.BillAmount;
                        return;
                    }
                }
            }
            throw new CustomerException("Customer details not found to update");
        }
    }


}