using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino1
{
    public class FraudException : Exception
    {
        public FraudException() //standard constructor
            : base() { }   //inheriting from base constructor(Exception)
        public FraudException(string message)
            : base(message) { }
    }
}
