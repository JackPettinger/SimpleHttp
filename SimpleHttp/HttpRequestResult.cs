using System;
using System.Net;

namespace SimpleHttp
{
    public class HttpRequestResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public String Message { get; set; }
        public Boolean Success { get; set; }
    }
}
