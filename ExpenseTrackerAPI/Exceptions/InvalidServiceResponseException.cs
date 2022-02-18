using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class InvalidServiceResponseException : Exception
    {
        public InvalidServiceResponseException(string endpoint, HttpStatusCode responseCode, string bodyContent)
            : this(endpoint, (int)responseCode, bodyContent)
        {
        }

        public InvalidServiceResponseException(string endpoint, int responseCode, string bodyContent)
            : base($"Error result calling an internal endpoint '{endpoint}' with result status code {responseCode} and body content {bodyContent}")
        {
            Endpoint = endpoint;
            ResponseStatusCode = responseCode;
            BodyContent = bodyContent;
        }

        public InvalidServiceResponseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string? Endpoint { get; }
        public int? ResponseStatusCode { get; }
        public string? BodyContent { get; }
    }
}
