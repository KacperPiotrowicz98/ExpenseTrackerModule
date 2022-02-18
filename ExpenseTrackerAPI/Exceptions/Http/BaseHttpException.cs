using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseHttpException : BaseException
    {
        public abstract HttpStatusCode StatusCode { get; }

        protected BaseHttpException()
        {
        }

        protected BaseHttpException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        protected BaseHttpException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        protected BaseHttpException(int? messageStatusCode, string message)
            : base(messageStatusCode, message)
        {
        }

        protected BaseHttpException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        protected BaseHttpException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        protected BaseHttpException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
