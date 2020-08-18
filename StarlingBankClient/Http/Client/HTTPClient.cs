using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using StarlingBankClient.Http.Request;
using StarlingBankClient.Http.Response;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Http.Client
{
    public class HTTPClient : IHTTPClient
    {
        public static IHTTPClient SharedClient { get; set; }
        private readonly HttpClient client = new HttpClient();
		

        static HTTPClient()
        {
            SharedClient = new HTTPClient();
        }

        public void SetTimeout(TimeSpan timeout)
        {
            client.Timeout = timeout;
        }


        #region Execute methods

        public HTTPResponse ExecuteAsString(HTTPRequest request)
        {
            var t = ExecuteAsStringAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        public async Task<HTTPResponse> ExecuteAsStringAsync(HTTPRequest request)
        {
            //raise the on before request event
            RaiseOnBeforeHttpRequestEvent(request);

            var responseMessage = await HTTPResponseMessageAsync(request).ConfigureAwait(false);

            HTTPResponse response = new HttpStringResponse
            {
                Headers = GetCombinedResponseHeaders(responseMessage),
                RawBody = await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false),
                Body = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false),
                StatusCode = (int)responseMessage.StatusCode
            };

            //raise the on after response event
            RaiseOnAfterHttpResponseEvent(response);
            return response;
        }

        public HTTPResponse ExecuteAsBinary(HTTPRequest request)
        {
            var t = ExecuteAsBinaryAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        public async Task<HTTPResponse> ExecuteAsBinaryAsync(HTTPRequest request)
        {
            //raise the on before request event
            RaiseOnBeforeHttpRequestEvent(request);

            var responseMessage = await HTTPResponseMessageAsync(request).ConfigureAwait(false);

            var response = new HTTPResponse
            {
                Headers = GetCombinedResponseHeaders(responseMessage),
                RawBody = await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false),
                StatusCode = (int)responseMessage.StatusCode
            };

            //raise the on after response event
            RaiseOnAfterHttpResponseEvent(response);
            return response;
        }

        #endregion


        #region Http request and response events

        public event OnBeforeHttpRequestEventHandler OnBeforeHttpRequestEvent;
        public event OnAfterHttpResponseEventHandler OnAfterHttpResponseEvent;

        private void RaiseOnBeforeHttpRequestEvent(HTTPRequest request)
        {
            if ((null != OnBeforeHttpRequestEvent) && (null != request))
                OnBeforeHttpRequestEvent(this, request);
        }

        private void RaiseOnAfterHttpResponseEvent(HTTPResponse response)
        {
            if ((null != OnAfterHttpResponseEvent) && (null != response))
                OnAfterHttpResponseEvent(this, response);
        }

        #endregion


        #region Http methods

        public HTTPRequest Get(string queryUrl, Dictionary<string, string> headers)
        {
            return new HTTPRequest(HttpMethod.Get, queryUrl, headers);
        }

        public HTTPRequest Get(string queryUrl)
        {
            return new HTTPRequest(HttpMethod.Get, queryUrl);
        }

        public HTTPRequest Post(string queryUrl)
        {
            return new HTTPRequest(HttpMethod.Post, queryUrl);
        }

        public HTTPRequest Put(string queryUrl)
        {
            return new HTTPRequest(HttpMethod.Put, queryUrl);
        }

        public HTTPRequest Delete(string queryUrl)
        {
            return new HTTPRequest(HttpMethod.Delete, queryUrl);
        }

        public HTTPRequest Patch(string queryUrl)
        {
            return new HTTPRequest(new HttpMethod("PATCH"), queryUrl);
        }

        public HTTPRequest Post(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, object>> formParameters)
        {
            return new HTTPRequest(HttpMethod.Post, queryUrl, headers, formParameters);
        }

        public HTTPRequest PostBody(string queryUrl, Dictionary<string, string> headers, object body)
        {
            return new HTTPRequest(HttpMethod.Post, queryUrl, headers, body);
        }

        public HTTPRequest Put(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, object>> formParameters)
        {
            return new HTTPRequest(HttpMethod.Put, queryUrl, headers, formParameters);
        }

        public HTTPRequest PutBody(string queryUrl, Dictionary<string, string> headers, object body)
        {
            return new HTTPRequest(HttpMethod.Put, queryUrl, headers, body);
        }

        public HTTPRequest Patch(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, object>> formParameters)
        {
            return new HTTPRequest(new HttpMethod("PATCH"), queryUrl, headers, formParameters);
        }

        public HTTPRequest PatchBody(string queryUrl, Dictionary<string, string> headers, object body)
        {
            return new HTTPRequest(new HttpMethod("PATCH"), queryUrl, headers, body);
        }

        public HTTPRequest Delete(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, object>> formParameters)
        {
            return new HTTPRequest(HttpMethod.Delete, queryUrl, headers, formParameters);
        }

        public HTTPRequest DeleteBody(string queryUrl, Dictionary<string, string> headers, object body)
        {
            return new HTTPRequest(HttpMethod.Delete, queryUrl, headers, body);
        }

        #endregion

        #region Helper methods

        private async Task<HttpResponseMessage> HTTPResponseMessageAsync(HTTPRequest request)
        {
            var requestMessage = new HttpRequestMessage
            {
                RequestUri = new Uri(request.QueryUrl),
                Method = request.HttpMethod,
            };
            foreach (var headers in request.Headers)
            {
                requestMessage.Headers.TryAddWithoutValidation(headers.Key, headers.Value);
            }

            if (request.HttpMethod.Equals(HttpMethod.Delete) || request.HttpMethod.Equals(HttpMethod.Post) || request.HttpMethod.Equals(HttpMethod.Put) || request.HttpMethod.Equals(new HttpMethod("PATCH")))
            {
                if (request.Body != null)
                {
                    if (request.Body is FileStreamInfo info)
                    {
                        var file = info;
                        requestMessage.Content = new StreamContent(file.FileStream);
                        requestMessage.Content.Headers.ContentType = !string.IsNullOrWhiteSpace(file.ContentType) ? new MediaTypeHeaderValue(file.ContentType) : new MediaTypeHeaderValue("application/octet-stream");
                    }
                    else if (request.Headers.Any(f => f.Key == "content-type" && f.Value == "application/json; charset=utf-8"))
                        requestMessage.Content = new StringContent((string)request.Body ?? string.Empty, Encoding.UTF8,
                            "application/json");
                    else if (request.Headers.ContainsKey("content-type"))
                    {
                        requestMessage.Content = new ByteArrayContent(
                            request.Body == null ? new byte[] { } : Encoding.UTF8.GetBytes((string)request.Body));

                        try
                        {
                            requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(request.Headers["content-type"]);
                        } catch(Exception)
                        {
                            requestMessage.Content.Headers.TryAddWithoutValidation("content-type", request.Headers["content-type"]);
                        }
                    }
                    else
                        requestMessage.Content = new StringContent(request.Body.ToString() ?? string.Empty, Encoding.UTF8,
                            "text/plain");
                }
                else if (request.FormParameters != null && request.FormParameters.Any(f => f.Value is FileStreamInfo))
                {
                    var formContent = new MultipartFormDataContent();
                    foreach (var param in request.FormParameters)
                    {
                        if (param.Value is FileStreamInfo fileInfo)
                        {
                            var fileContent = new StreamContent(fileInfo.FileStream);
                            if (string.IsNullOrEmpty(fileInfo.FileName))
                                fileInfo.FileName = "file";
                            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                            {
                                Name = param.Key,
                                FileName = fileInfo.FileName
                            };
                            fileContent.Headers.ContentType = !string.IsNullOrWhiteSpace(fileInfo.ContentType) ? new MediaTypeHeaderValue(fileInfo.ContentType) : new MediaTypeHeaderValue("application/octet-stream");
                            formContent.Add(fileContent, param.Key);
                        }
                        else
                            formContent.Add(new StringContent(param.Value.ToString()), param.Key);
                    }
                    requestMessage.Content = formContent;
                }
                else if (request.FormParameters != null)
                {
                    var parameters = new List<KeyValuePair<string, string>>();
                    foreach (var param in request.FormParameters)
                    {
                        parameters.Add(new KeyValuePair<string, string>(param.Key, param.Value.ToString()));
                    }
                    requestMessage.Content = new FormUrlEncodedContent(parameters);
                }
            }
            return await client.SendAsync(requestMessage).ConfigureAwait(false);
        }

        private static Dictionary<string, string> GetCombinedResponseHeaders(HttpResponseMessage responseMessage)
        {
            var headers = responseMessage.Headers.ToDictionary(l => l.Key, k => k.Value.First());
            if (responseMessage.Content != null)
            {
                foreach (var contentHeader in responseMessage.Content.Headers)
                {
                    if (headers.ContainsKey(contentHeader.Key)) continue;
                    headers.Add(contentHeader.Key, contentHeader.Value.First());
                }
            }
            return headers;
        }

        #endregion
    }
}
