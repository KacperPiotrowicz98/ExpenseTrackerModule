using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class UnparsableStripeEventTypeException<T> : Exception
    {
        public UnparsableStripeEventTypeException(string notificationJson)
            : base($"Unable to parse the Stripe Event from type {typeof(T).FullName ?? typeof(T).Name}")
        {
            NotificationJson = notificationJson;
        }

        public UnparsableStripeEventTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string? NotificationJson { get; set; }
    }
}
