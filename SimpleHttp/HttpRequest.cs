using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleHttp
{
    public class HttpRequest : IHttpRequest
    {
        private readonly HttpClient _httpClient;

        public HttpRequest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpRequestResult> Send(HttpRequestMessage requestMessage)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(requestMessage);
        }
    }
}
