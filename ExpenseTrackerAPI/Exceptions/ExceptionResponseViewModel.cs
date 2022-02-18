using System.Diagnostics.CodeAnalysis;

using Newtonsoft.Json;

namespace ExpenseTrackerAPI.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class ExceptionResponseViewModel
    {
        public int StatusCode { get; init; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageStatusCode { get; init; }

        public string? Message { get; init; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayMessage { get; init; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? StackTrace { get; set; }
    }
}
