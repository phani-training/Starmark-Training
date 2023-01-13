using DataLayer;
using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLayer;

namespace DataLayer
{
    class ListCollection : IDataComponent
    {
        public ListCollection()
        {
            Console.WriteLine("List is being used");
        }
        List<Customer> customers = new List<Customer>();
        public void AddNewCustomer(Customer cst) => customers.Add(cst);

        public void DeleteCustomer(int id)
        {
            foreach (var cst in customers)
            {
                if (cst.CustomerId == id)
                {
                    customers.Remove(cst);
                    return;
                }
            }
            throw new CustomerException("Customer not found to Delete");
        }

        public Customer[] GetAllCustomers() => customers.ToArray();

        public void UpdateCustomer(Customer customer)
        {
            foreach (var cst in customers)
            {
                if (cst.CustomerId == customer.CustomerId)
                {
                    cst.Copy(customer);
                    return;
                }
            }
            throw new CustomerException("Customer not found to Delete");
        }
    }
}
