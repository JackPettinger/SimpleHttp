using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleHttp
{
    internal interface IHttpRequest
    {
        Task<HttpRequestResult> Send(HttpRequestMessage requestMessage);
    }
}
