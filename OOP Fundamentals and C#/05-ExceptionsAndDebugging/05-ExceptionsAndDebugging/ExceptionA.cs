using System;
using System.Runtime.Serialization;

namespace _05_ExceptionsAndDebugging
{
    [Serializable]
    internal class ExceptionA : Exception
    {
        public ExceptionA()
        {
        }

        public ExceptionA(string message) : base(message)
        {
        }

        public ExceptionA(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ExceptionA(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}