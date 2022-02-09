using RestaurantOrderRouting.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.WebApp.Services.Interfaces
{
    public interface IHttpService
    {
        Task<Response<T>> PostAsync<TValue, T>(string url, TValue value);
        Task<Response<T>> GetAsync<T>(string url);
        Task<Response<string>> DeleteAsync(string url);
    }
}
