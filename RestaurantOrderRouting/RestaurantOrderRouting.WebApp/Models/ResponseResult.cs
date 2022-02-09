using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.WebApp.Models
{
    public class ResponseResult<T>
    {
        [JsonPropertyName("result")]
        public T Result { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("timeGenerated")]
        public DateTime TimeGenerated { get; set; }
    }
}
