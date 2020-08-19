using System;
using System.IO;
using Newtonsoft.Json;
using StarlingBank.Exceptions;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class BaseController
    {
        #region shared http client instance
        private static readonly object SyncObject = new object();
        private static IHTTPClient _clientInstance;

        public static IHTTPClient ClientInstance
        {
            get
            {
                lock(SyncObject)
                {
                    if (null != _clientInstance) return _clientInstance;
                    _clientInstance = new HTTPClient();
                    _clientInstance.SetTimeout(TimeSpan.FromMilliseconds(30000));
                    return _clientInstance;
                }
            }
            set
            {
                lock (SyncObject)
                {
                    if (value != null)
                    {
                        _clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        internal ArrayDeserialization ArrayDeserializationFormat = ArrayDeserialization.Indexed;
        internal static char ParameterSeparator = '&';

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="response">The response received</param>
        /// <param name="context">Context of the request and the received response</param>
        internal void ValidateResponse(HTTPResponse response, HTTPContext context)
        {
            if ((response.StatusCode >= 200) && (response.StatusCode <= 208)) return;//[200,208] = HTTP OK
            // ReSharper disable once RedundantAssignment
            var errorHeader = "HTTP Response Not OK";
            if ((response.StatusCode >= 300) && (response.StatusCode < 400))
            {
                errorHeader = "HTTP Redirection Error " + response.StatusCode + " - ";
                switch (response.StatusCode)
                {
                    case 300:
                        errorHeader = errorHeader + " Multiple Choices" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 301:
                        errorHeader = errorHeader + "  Moved Permanently" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 302:
                        errorHeader = errorHeader + " Found" + ParseBody(response) + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 303:
                        errorHeader = errorHeader + "  See Other" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 304:
                        errorHeader = errorHeader + "  Not Modified" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 305:
                        errorHeader = errorHeader + "  Use Proxy" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 307:
                        errorHeader = errorHeader + "  Temporary Redirect" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 308:
                        errorHeader = errorHeader + "  Permanent Redirect" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    default:
                        throw new ErrorResponseException(errorHeader, context);
                }
            }

            if ((response.StatusCode >= 400) && (response.StatusCode < 500))
            {
                errorHeader = "HTTP Client Error " + response.StatusCode + " - ";
                switch (response.StatusCode)
                {
                    case 400:
                        errorHeader = errorHeader + "Bad Request" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 401:
                        errorHeader = errorHeader + " Unauthorized" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 402:
                        errorHeader = errorHeader + " Payment Required" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 403:
                        errorHeader = errorHeader + " Forbidden" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 404:
                        errorHeader = errorHeader + " Not Found" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 405:
                        errorHeader = errorHeader + " Method Not Allowed" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 406:
                        errorHeader = errorHeader + " Not Acceptable" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 407:
                        errorHeader = errorHeader + " Proxy Authentication Required" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 408:
                        errorHeader = errorHeader + " Request Timeout" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 409:
                        errorHeader = errorHeader + " Conflict" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 410:
                        errorHeader = errorHeader + " Gone" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 411:
                        errorHeader = errorHeader + " Length Required" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 412:
                        errorHeader = errorHeader + " Precondition Failed" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 413:
                        errorHeader = errorHeader + " Payload Too Large" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 414:
                        errorHeader = errorHeader + " Request - URI Too Long" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 415:
                        errorHeader = errorHeader + " Unsupported Media Type" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 416:
                        errorHeader = errorHeader + " Requested Range Not Satisfiable" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 417:
                        errorHeader = errorHeader + " Expectation Failed" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 421:
                        errorHeader = errorHeader + " Misdirected Request" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 422:
                        errorHeader = errorHeader + " Unprocessable Entity" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 423:
                        errorHeader = errorHeader + " Locked" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 424:
                        errorHeader = errorHeader + " Failed Dependency" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 426:
                        errorHeader = errorHeader + " Upgrade Required" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 428:
                        errorHeader = errorHeader + " Precondition Required" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 429:
                        errorHeader = errorHeader + " Too Many Requests" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 431:
                        errorHeader = errorHeader + " Request Header Fields Too Large" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 444:
                        errorHeader = errorHeader + " Connection Closed Without Response" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 451:
                        errorHeader = errorHeader + " Unavailable For Legal Reasons" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    case 499:
                        errorHeader = errorHeader + " Client Closed Request" + ParseBody(response);
                        throw new ErrorResponseException(errorHeader, context);
                    default:
                        throw new ErrorResponseException(errorHeader, context);
                }
            }

            if ((response.StatusCode >= 500) && (response.StatusCode < 600))
            {
                errorHeader = "HTTP Server Error " + response.StatusCode + " - ";
                switch (response.StatusCode)
                {
                    case 500:
                        errorHeader = errorHeader + " Internal Server Error" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 501:
                        errorHeader = errorHeader + " Not Implemented" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 502:
                        errorHeader = errorHeader + " Bad Gateway" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 503:
                        errorHeader = errorHeader + " Service Unavailable" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 504:
                        errorHeader = errorHeader + " Gateway Timeout" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 505:
                        errorHeader = errorHeader + " HTTP Version Not Supported" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 506:
                        errorHeader = errorHeader + " Variant Also Negotiates" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 507:
                        errorHeader = errorHeader + " Insufficient Storage" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 508:
                        errorHeader = errorHeader + " Loop Detected" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 510:
                        errorHeader = errorHeader + " Not Extended" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 511:
                        errorHeader = errorHeader + " Network Authentication Required" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    case 599:
                        errorHeader = errorHeader + " Network Connect Timeout Error" + ParseBody(response);
                        throw new APIException(errorHeader, context);
                    default:
                        throw new APIException(errorHeader, context);
                }
            }


        }

        internal string ParseBody(HTTPResponse response)
        {
            var errorMessage = "";
            var receiveStream = response.RawBody;
            var encode = System.Text.Encoding.GetEncoding("utf-8");
            // Pipes the stream to a higher level stream reader with the required encoding format.
            using (var sr = new StreamReader(receiveStream, encode))
            {
                var s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (s.StartsWith("{ \"error\":"))
                    {
                        var error = JsonConvert.DeserializeObject<Error>(s);
                        if (error == null) continue;
                        if (error.error != null && error.error.Length > 1)
                        {
                            errorMessage = " - " + char.ToUpper(error.error[0]) + error.error.Substring(1).Replace("_", " ");
                        }
                        if (error.error_description != null)
                        {
                            errorMessage = errorMessage + " : " + char.ToUpper(error.error_description[0]) + error.error_description.Substring(1);
                        }
                    }
                    else if (s.StartsWith("[\"INVALID_END_DATE\"]"))
                    {
                        errorMessage = " - Invalid End Date";
                    }

                }
            }
            return errorMessage;
            //{ "error":"signature_check_failed","error_description":"missing date header"}
        }

        public class Error
        {
            public string error { get; set; }
            public string error_description { get; set; }
        }
    }
} 