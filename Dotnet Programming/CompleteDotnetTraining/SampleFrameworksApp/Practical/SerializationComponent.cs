using DataLayer;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UtilitiesLayer;
using System.Diagnostics;

namespace SampleFrameworksApp.Practical
{
    class SerializationComponent : IDataComponent
    {
        const string fileName = "AllCustomers.xml";
        List<Customer> _customers = new List<Customer>();
        private void saveData()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            
            Debug.WriteLine("File saved thru Serialization");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            serializer.Serialize(fs, _customers);
            fs.Flush();
            fs.Close();
        }

        public void loadData()
        {
            Debug.WriteLine("File retrived thru Deserialization");
            if (!File.Exists(fileName))
            {
                _customers = new List<Customer>();
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            _customers = serializer.Deserialize(fs) as List<Customer>;
            fs.Flush();
            fs.Close();
        }
        public void AddNewCustomer(Customer cst)
        {
            loadData();
            _customers.Add(cst);
            saveData();
        }

        public void DeleteCustomer(int id)
        {
            loadData();
            var cst = _customers.Find((c) => c.CustomerId == id);
            _customers.Remove(cst);
            saveData();
        }

        public Customer[] GetAllCustomers()
        {
            loadData();
            return _customers.ToArray();
        }

        public void UpdateCustomer(Customer cst)
        {
            loadData();
            var selected = _customers.Find((c) => c.CustomerId == cst.CustomerId);
            if (selected == null) throw new CustomerException("Customer not found to update");
            selected.CustomerName = cst.CustomerName;
            selected.CustomerAddress = cst.CustomerAddress;
            selected.BillAmount = cst.BillAmount;
            saveData();
        }
    }
}
