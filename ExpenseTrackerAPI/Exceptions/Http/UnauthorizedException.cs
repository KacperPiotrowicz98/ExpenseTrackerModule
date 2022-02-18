using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class UnauthorizedException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;

        public UnauthorizedException()
        {
        }

        public UnauthorizedException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public UnauthorizedException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public UnauthorizedException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public UnauthorizedException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public UnauthorizedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
