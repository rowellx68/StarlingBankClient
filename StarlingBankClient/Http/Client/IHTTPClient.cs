using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StarlingBank.Http.Request;
using StarlingBank.Http.Response;

// ReSharper disable UnusedMember.Global

namespace StarlingBank.Http.Client
{
	public interface IHTTPClient
    {
        /// <summary>
        /// Sets the time to wait before the request times out.
        ///<param name="timeout"> A timespan object specifying the time to wait</param>
        /// </summary>
        void SetTimeout(TimeSpan timeout);
        /// <summary>
        /// Event raised before an Http request is sent over the network
        /// This event can be used for logging, request modification, appending
        /// additional headers etc.
        /// </summary>
        event OnBeforeHttpRequestEventHandler OnBeforeHttpRequestEvent;

        /// <summary>
        /// Event raised after an Http response is received from the network.
        /// This event can be used for logging, response modification, extracting
        /// additional information etc.
        /// </summary>
        event OnAfterHttpResponseEventHandler OnAfterHttpResponseEvent;

        /// <summary>
        /// Execute a given HTTPRequest to get string response back
        /// </summary>
        /// <param name="request">The given HTTPRequest to execute</param>
        /// <returns> HTTPResponse containing raw information</returns>
        HTTPResponse ExecuteAsString(HTTPRequest request);

        /// <summary>
        /// Execute a given HTTPRequest to get binary response back
        /// </summary>
        /// <param name="request">The given HTTPRequest to execute</param>
        /// <returns> HTTPResponse containing raw information</returns>
        HTTPResponse ExecuteAsBinary(HTTPRequest request);

        /// <summary>
        /// Execute a given HTTPRequest to get async string response back
        /// </summary>
        /// <param name="request">The given HTTPRequest to execute</param>
        /// <returns> HTTPResponse containing raw information</returns>
        Task<HTTPResponse> ExecuteAsStringAsync(HTTPRequest request);

        /// <summary>
        /// Execute a given HTTPRequest to get async binary response back
        /// </summary>
        /// <param name="request">The given HTTPRequest to execute</param>
        /// <returns> HTTPResponse containing raw information</returns>
        Task<HTTPResponse> ExecuteAsBinaryAsync(HTTPRequest request);

        /// <summary>
        /// Create a simple HTTP GET request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns>HTTPRequest initialised with the url specified</returns>
        HTTPRequest Get(string queryUrl);

        /// <summary>
        /// Create a simple HTTP POST request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HTTPRequest initialised with the url specified</returns>
        HTTPRequest Post(string queryUrl);

        /// <summary>
        /// Create a simple HTTP PUT request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HTTPRequest initialised with the url specified</returns>
        HTTPRequest Put(string queryUrl);

        /// <summary>
        /// Create a simple HTTP DELETE request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns>HTTPRequest initialised with the url specified</returns>
        HTTPRequest Delete(string queryUrl);

        /// <summary>
        /// Create a simple HTTP PATCH request given the URL
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <returns> HTTPRequest initialised with the url specified</returns>
        HTTPRequest Patch(string queryUrl);

        /// <summary>
        /// Create a simple HTTP GET request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest Get(string queryUrl, Dictionary<string, string> headers);

        /// <summary>
        ///  Create a simple HTTP POST request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest Post(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters);

        /// <summary>
        /// Create a simple HTTP POST with a body request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest PostBody(string queryUrl, Dictionary<string, string> headers, object body);

        /// <summary>
        ///  Create a simple HTTP PUT request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest Put(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters);

        /// <summary>
        /// Create a simple HTTP PUT with a body request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest PutBody(string queryUrl, Dictionary<string, string> headers, object body);

        /// <summary>
        ///  Create a simple HTTP PATCH request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest Patch(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters);

        /// <summary>
        /// Create a simple HTTP Patch with a body request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest PatchBody(string queryUrl, Dictionary<string, string> headers, object body);

        /// <summary>
        ///  Create a simple HTTP DELETE request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="formParameters">Form parameters to be included</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest Delete(string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters);

        /// <summary>
        /// Create a simple HTTP Delete with a body request given relevant parameters
        /// </summary>
        /// <param name="queryUrl">Url the request should be sent to</param>
        /// <param name="headers">HTTP headers that should be included</param>
        /// <param name="body">The body/payload of the response</param>
        /// <returns> HTTPRequest initialised with the http parameters specified</returns>
        HTTPRequest DeleteBody(string queryUrl, Dictionary<string, string> headers, object body);
    }
}

