using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_заданий_new
{
    internal class MyExp : ApplicationException
    {
        private string _message;
        public DateTime TimeException { get; private set; }

        public MyExp()
        {
            _message = "My exception!";
            TimeException = DateTime.Now;
        }
        public override string Message
        {
            get { return _message; }
        }
    }

    internal class MyException : ApplicationException
    {
        public DateTime TimeException { get; private set; }
        public MyException() : base("MY EXCEPTION!!")
        {
            TimeException = DateTime.Now;
        }
    }
}
