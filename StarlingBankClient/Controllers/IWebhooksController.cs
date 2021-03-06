using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface IWebhooksController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        void CreateDispatchWebhook(DefaultWebhookPayloadModel body = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        Task CreateDispatchWebhookAsync(DefaultWebhookPayloadModel body = null);

    }
} 