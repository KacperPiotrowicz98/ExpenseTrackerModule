using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class NotFoundException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        public NotFoundException()
        {
        }

        public NotFoundException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public NotFoundException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public NotFoundException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public NotFoundException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public NotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
