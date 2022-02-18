using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;

using Microsoft.AspNetCore.JsonPatch.Operations;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class UnhandledPropertyUpdatedException<T> : Exception
    {
        public UnhandledPropertyUpdatedException(string propertyName, OperationType operationType)
            : base($"Unable to modify property at path {typeof(T).Name}.{propertyName} with operation {operationType} because modifying that property is unhandled")
        {
        }

        public UnhandledPropertyUpdatedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
