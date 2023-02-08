using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{

    public class BookDataException : Exception
    {
        public BookDataException() { }
        public BookDataException(string message) : base(message) { }
        public BookDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}
