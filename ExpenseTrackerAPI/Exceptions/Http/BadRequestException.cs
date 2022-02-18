using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class BadRequestException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public BadRequestException()
        {
        }

        public BadRequestException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public BadRequestException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public BadRequestException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public BadRequestException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public BadRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
