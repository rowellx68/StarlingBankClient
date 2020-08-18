using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBankClient.Http.Client;
using StarlingBankClient.Models;

namespace StarlingBankClient.Exceptions
{
    public class ErrorResponseException : APIException 
    {
        // These fields hold the values for the public properties.

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public List<ErrorDetail> Errors { get; private set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; private set; }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorResponseException(string reason, HTTPContext context)
            : base(reason, context)
        {
        }
    }
} 