using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class CustomHttpException : BaseHttpException
    {
        public override HttpStatusCode StatusCode { get; }

        public CustomHttpException()
        {
        }

        public CustomHttpException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public CustomHttpException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public CustomHttpException(HttpStatusCode statusCode, ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
            StatusCode = statusCode;
        }

        public CustomHttpException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public CustomHttpException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public CustomHttpException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public CustomHttpException(HttpStatusCode statusCode, string message, int? messageStatusCode = null)
            : base(messageStatusCode, message)
        {
            StatusCode = statusCode;
        }
    }
}
