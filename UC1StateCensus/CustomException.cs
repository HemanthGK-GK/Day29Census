using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
    class CustomException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND  ,
            HEADER_NOT_MATCH
        }

        public ExceptionType type;
       
        public CustomException(string message, ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}
