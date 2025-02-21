using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.ViewModel
{
    public class ApiResponse
    {
        public ApiResponse(string? status, string? message, object? data)
        {
            this.Status = status;
            this.Message = message;
            this.Data = data;
        }
        public string? Status { get; set; }

        public string? Message { get; set; }

        public object? Data { get; set; }

    }
}
