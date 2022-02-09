using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Crosscutting.Util
{
    public class Envelope<T>
    {
        [JsonPropertyName("result")]
        public T Result { get; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; }

        [JsonPropertyName("timeGenerated")]
        public DateTime TimeGenerated { get; }
        public Envelope() { }

        protected internal Envelope(T result, string errorMessage)
        {
            Result = result;
            ErrorMessage = errorMessage;
            TimeGenerated = DateTime.UtcNow;
        }
    }

    public class Envelope : Envelope<string>
    {
        protected Envelope(string errorMessage)
            : base(null, errorMessage)
        {
        }

        public static Envelope<T> Ok<T>(T result)
        {
            return new Envelope<T>(result, null);
        }

        public static Envelope Ok()
        {
            return new Envelope(null);
        }

        public static Envelope Error(string errorMessage)
        {
            return new Envelope(errorMessage);
        }
    }
}
