﻿using System.Net;

namespace PubHubWeb.Services
{
    public class ApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? Data { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}