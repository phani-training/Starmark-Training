using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp.Practical
{
    /// <summary>
    /// Represents the entity of our application.
    /// </summary>
    public class Customer : IComparable<Customer>
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int BillAmount { get; set; }

        public void Copy(Customer cst)
        {
            CustomerId = cst.CustomerId;
            CustomerName = cst.CustomerName;
            CustomerAddress = cst.CustomerAddress;
            BillAmount = cst.BillAmount;
        }
        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }
        //Logical equivalence of UR object
        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                var unBoxed = obj as Customer;
                if (CustomerId == unBoxed.CustomerId && CustomerName == unBoxed.CustomerName && CustomerAddress == unBoxed.CustomerAddress)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            // return $"Name: {CustomerName} from {CustomerAddress} with Bill Amount: {BillAmount}";
            return $"{CustomerId}, {CustomerName}, {CustomerAddress}, {BillAmount}\n";
        }

        public int CompareTo(Customer other)
        {
            return BillAmount.CompareTo(other.BillAmount);
        }
    }

    enum Criteria { ID, Name, Address, Bill }
    class CustomerComparer : IComparer<Customer>
    {
        private Criteria criteria;
        public CustomerComparer(Criteria criteria)
        {
            this.criteria = criteria;
        }

        public int Compare(Customer x, Customer y)
        {
            switch (criteria)
            {
                case Criteria.ID:
                    return x.CustomerId.CompareTo(y.CustomerId);
                case Criteria.Name:
                    return x.CustomerName.CompareTo(y.CustomerName);
                case Criteria.Address:
                    return x.CustomerAddress.CompareTo(y.CustomerAddress);
                case Criteria.Bill:
                    return x.CompareTo(y);
            }
            return 0;
        }
    }
}
