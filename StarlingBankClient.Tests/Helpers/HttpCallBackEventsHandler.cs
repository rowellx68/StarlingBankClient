using StarlingBankClient.Http.Client;
using StarlingBankClient.Http.Request;
using StarlingBankClient.Http.Response;

namespace StarlingBankClient.Tests.Helpers
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
