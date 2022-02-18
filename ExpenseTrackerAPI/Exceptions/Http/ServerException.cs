using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions.Http
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class ServerException : BaseHttpException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

        public ServerException()
        {
        }

        public ServerException(int? messageStatusCode)
            : base(messageStatusCode)
        {
        }

        public ServerException(ExpenseApiDisplayMessage displayMessage)
            : base(displayMessage)
        {
        }

        public ServerException(ExpenseApiDisplayMessage displayMessage, string message)
            : base(displayMessage, message)
        {
        }

        public ServerException(string message, Exception? exception = null)
            : base(message, exception)
        {
        }

        public ServerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
