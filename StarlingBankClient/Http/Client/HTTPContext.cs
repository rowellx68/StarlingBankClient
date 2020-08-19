using StarlingBank.Http.Request;
using StarlingBank.Http.Response;

namespace StarlingBank.Http.Client
{
    /// <summary>
    /// Represents the contextual information of HTTP request and response
    /// </summary>
    public class HTTPContext
    {
        /// <summary>
        /// The HTTP request in the current context
        /// </summary>
        public HTTPRequest Request { get; set; }

        /// <summary>
        /// The HTTP response in the current context
        /// </summary>
        public HTTPResponse Response { get; set; }

        /// <summary>
        /// Constructor to initialize the context with HTTP request and response information
        /// </summary>
        /// <param name="request">The HTTP request in the current context</param>
        /// <param name="response">The HTTP response in the current context</param>
        public HTTPContext(HTTPRequest request, HTTPResponse response)
        {
            Request = request;
            Response = response;
        }
    }
}
