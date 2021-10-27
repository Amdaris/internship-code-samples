using System;
using System.Runtime.Serialization;

namespace _05_ExceptionsAndDebugging
{
    [Serializable]
    internal class ExceptionB : Exception
    {
        public ExceptionB()
        {
        }

        public ExceptionB(string message) : base(message)
        {
        }

        public ExceptionB(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionB(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}