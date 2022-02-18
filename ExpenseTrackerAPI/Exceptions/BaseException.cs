using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseException : Exception
    {
        public int? MessageStatusCode { get; set; }

        protected BaseException()
        {
        }

        protected BaseException(int? messageStatusCode)
        {
            MessageStatusCode = messageStatusCode;
        }

        protected BaseException(ExpenseApiDisplayMessage displayMessage)
        {
            MessageStatusCode = displayMessage.Id;
        }

        protected BaseException(int? messageStatusCode, string message)
            : base(message)
        {
            MessageStatusCode = messageStatusCode;
        }

        protected BaseException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(message)
        {
            MessageStatusCode = displayMessage.Id;
        }

        protected BaseException(string message, Exception? exception)
            : base(message, exception)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
