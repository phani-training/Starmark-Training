using System;
using System.Configuration;
using DataLayer;
using SampleFrameworksApp.Practical;

namespace UtilitiesLayer
{
    static class CustomerFactory
    {
        public static IDataComponent GetComponent(string type)
        {
            IDataComponent component = null;
            switch (type.ToLower())
            {
                case "list": return new ListCollection();
                case "arraylist": return new CustomerDatabase();
                case "serialization": return new SerializationComponent();
                default:
                    throw new CustomerException("This type is not supported by us");
            }
        }
    }
}        