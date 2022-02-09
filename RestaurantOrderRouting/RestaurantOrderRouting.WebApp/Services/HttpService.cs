using Microsoft.Extensions.Configuration;
using RestaurantOrderRouting.Crosscutting.Util;
using RestaurantOrderRouting.WebApp.Models;
using RestaurantOrderRouting.WebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.WebApp.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public HttpService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Response<T>> PostAsync<TValue, T>(string url, TValue value)
        {
            var response = new Response<T>();

            try
            {
                var result = await _httpClient.PostAsJsonAsync(url, value);
                var responseResult = await result.Content.ReadFromJsonAsync<ResponseResult<T>>();

                if (!string.IsNullOrEmpty(responseResult.ErrorMessage))
                {
                    response.MessageClass = "danger";
                    response.Message = responseResult.ErrorMessage;
                }
                else
                {
                    response.MessageClass = "success";
                }

                response.ResponseResult = responseResult;
            }
            catch (Exception ex)
            {
                response.MessageClass = "danger";
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<T>> GetAsync<T>(string url)
        {
            var response = new Response<T>();

            try
            {
                var result = await _httpClient.GetAsync(url);

                if (result.IsSuccessStatusCode)
                    response.ResponseResult = await result.Content.ReadFromJsonAsync<ResponseResult<T>>();
                else
                {
                    response.MessageClass = "danger";
                    response.Message = result.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                response.MessageClass = "danger";
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<string>> DeleteAsync(string url)
        {
            var response = new Response<string>();

            try
            {
                var result = await _httpClient.DeleteAsync(url);
                var responseResult = await result.Content.ReadFromJsonAsync<ResponseResult<string>>();

                if (!string.IsNullOrEmpty(responseResult.ErrorMessage))
                {
                    response.MessageClass = "danger";
                    response.Message = responseResult.ErrorMessage;
                }
                else
                {
                    response.MessageClass = "success";
                }

                response.ResponseResult = responseResult;
            }
            catch (Exception ex)
            {
                response.MessageClass = "danger";
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
