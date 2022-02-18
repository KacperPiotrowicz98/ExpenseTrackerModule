using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class UnprocessableEntityException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.UnprocessableEntity;

        public UnprocessableEntityException()
        {
        }

        public UnprocessableEntityException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public UnprocessableEntityException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public UnprocessableEntityException(int? messageStatusCode, string message)
            : base(messageStatusCode, message)
        {
        }

        public UnprocessableEntityException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public UnprocessableEntityException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public UnprocessableEntityException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
