using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class UnknownStripeEventTypeException : Exception
    {
        public UnknownStripeEventTypeException()
        {
        }

        public UnknownStripeEventTypeException(string? notificationJson)
            : base($"Unable to parse the Stripe Event Type from an event")
        {
            NotificationJson = notificationJson;
        }

        public UnknownStripeEventTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string? NotificationJson { get; set; }
    }
}
