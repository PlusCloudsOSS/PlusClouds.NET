using System;

namespace PlusClouds.Net.Exceptions
{
    public class PlusConfigInvalidException : ArgumentException
    {
        public PlusConfigInvalidException(string message) : base(message)
        {
        }

        public PlusConfigInvalidException(string message, string paraeter) : base(message, paraeter)
        {
        }

        public PlusConfigInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}