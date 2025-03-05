using core.Helper;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;

namespace core.ViewModel
{
    public class ApiResponse
    {
        public ApiResponse(HttpStatusCode? statusCode, APIStatus? status, string? message, object? data)
        {
            this.StatusCode = statusCode;
            this.Status = status.ToString();
            this.Message = message;
            this.Data = data;
        }

        public HttpStatusCode? StatusCode { get; set; }
        public string? Status { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }

    }
}
