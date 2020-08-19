using StarlingBank.Http.Client;
using StarlingBank.Http.Request;
using StarlingBank.Http.Response;

namespace StarlingBank.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HTTPRequest Request { get; private set; }

        public HTTPResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHTTPClient source, HTTPRequest request)
        {
            Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHTTPClient source, HTTPResponse response)
        {
            Response = response;
        }
    }
}
