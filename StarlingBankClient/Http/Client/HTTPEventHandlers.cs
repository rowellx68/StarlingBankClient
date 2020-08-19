using StarlingBank.Http.Request;
using StarlingBank.Http.Response;

namespace StarlingBank.Http.Client
{
    /// <summary>
    /// Delegate to handle the event on before HTTP request. This event is raised before any
    /// network call is made, and can be used for logging, request modification, appending
    /// additional headers etc.
    /// </summary>
    /// <param name="source">The source HTTPClient that is going to make the network call</param>
    /// <param name="request">The underlying HTTPRequest being sent over the network</param>
    public delegate void OnBeforeHttpRequestEventHandler(IHTTPClient source, HTTPRequest request);

    /// <summary>
    /// Delegate to handle the event on after HTTP response. This event is raised after any
    /// network response is received, and can be used for logging, response modification, extracting
    /// additional information etc.
    /// </summary>
    /// <param name="source">The source HTTPClient that received the response from the network call</param>
    /// <param name="response">The underlying HTTPResponse received from the network</param>
    public delegate void OnAfterHttpResponseEventHandler(IHTTPClient source, HTTPResponse response);
}
