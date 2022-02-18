using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class ForbiddenException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.Forbidden;

        public ForbiddenException()
        {
        }

        public ForbiddenException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public ForbiddenException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public ForbiddenException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public ForbiddenException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public ForbiddenException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
