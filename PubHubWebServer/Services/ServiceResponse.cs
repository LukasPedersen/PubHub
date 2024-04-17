using System.Net;

namespace PubHubWebServer.Services
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
