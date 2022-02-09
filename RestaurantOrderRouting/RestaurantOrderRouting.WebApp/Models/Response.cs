using RestaurantOrderRouting.Crosscutting.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.WebApp.Models
{
    public class Response<T>
    {
        public string MessageClass { get; set; }
        public string Message { get; set; }
        public ResponseResult<T> ResponseResult { get; set; }
        public bool IsSuccess
            => ResponseResult != null && string.IsNullOrEmpty(ResponseResult.ErrorMessage) ? true : false;
    }
}
