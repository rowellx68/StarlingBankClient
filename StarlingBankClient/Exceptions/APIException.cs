using System;
using System.IO;
using Newtonsoft.Json;
using StarlingBank.Http.Client;

namespace StarlingBank.Exceptions
{
    [JsonObject]
    public class APIException : Exception
    {
        /// <summary>
        /// The HTTP response code from the API request
        /// </summary>
        public int ResponseCode => HttpContext?.Response.StatusCode ?? -1;

        /// <summary>
        /// HTTPContext stores the request and response
        /// </summary>
        public HTTPContext HttpContext { get; set; }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public APIException(string reason, HTTPContext context)
            : base(reason)
        {
            HttpContext = context;

            //if a derived exception class is used, then perform deserialization of response body
            if ((GetType().Name.Equals("APIException", StringComparison.OrdinalIgnoreCase)) || context?.Response?.RawBody == null || (!context.Response.RawBody.CanRead))
                return;

            using (var reader = new StreamReader(context.Response.RawBody))
            {
                var responseBody = reader.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(responseBody))
                {
                    try { JsonConvert.PopulateObject(responseBody, this); }
                    catch
                    {} //ignoring response body from deserailization
                }
            }
        }
    }
}