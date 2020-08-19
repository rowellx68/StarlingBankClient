using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global

namespace StarlingBank.Controllers
{
    public interface IDirectDebitMandatesController
    {
        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        DirectDebitMandateV2 GetMandate(Guid mandateUid);

        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        Task<DirectDebitMandateV2> GetMandateAsync(Guid mandateUid);

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteCancelMandate(Guid mandateUid);

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteCancelMandateAsync(Guid mandateUid);

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        DirectDebitPaymentsResponse ListPaymentsForMandate(Guid mandateUid, DateTime since);

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        Task<DirectDebitPaymentsResponse> ListPaymentsForMandateAsync(Guid mandateUid, DateTime since);

        /// <summary>
        /// Get a list of direct debit mandates
        /// </summary>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        DirectDebitMandatesV2 ListMandates();

        /// <summary>
        /// Get a list of direct debit mandates
        /// </summary>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        Task<DirectDebitMandatesV2> ListMandatesAsync();

    }
} 