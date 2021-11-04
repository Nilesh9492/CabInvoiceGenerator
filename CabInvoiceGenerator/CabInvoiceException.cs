using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE, INVALID_DISTANCE, INVALID_TIME, INVALID_USER_ID, NULL_RIDES
        }

        ExceptionType exceptionType;
        public CabInvoiceException(ExceptionType eType, string message) : base(message)
        {
            this.exceptionType = eType;
        }
    }
}
