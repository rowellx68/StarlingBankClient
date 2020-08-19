using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface IPayeesController
    {
        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <return>Returns the Models.Payees response from the API call</return>
        Payees GetPayees();

        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <return>Returns the Models.Payees response from the API call</return>
        Task<Payees> GetPayeesAsync();

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="body">Required parameter: Payee creation object</param>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        PayeeCreationResponse CreatePayee(PayeeCreationRequest body);

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="body">Required parameter: Payee creation object</param>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        Task<PayeeCreationResponse> CreatePayeeAsync(PayeeCreationRequest body);

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="body">Required parameter: Payee account creation object</param>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        PayeeAccountCreationResponse CreatePayeeAccount(Guid payeeUid, PayeeAccountCreationRequest body);

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="body">Required parameter: Payee account creation object</param>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        Task<PayeeAccountCreationResponse> CreatePayeeAccountAsync(Guid payeeUid, PayeeAccountCreationRequest body);

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        ScheduledPayments ListPaymentOrdersForAccount(Guid payeeUid, Guid accountUid);

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        Task<ScheduledPayments> ListPaymentOrdersForAccountAsync(Guid payeeUid, Guid accountUid);

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the void response from the API call</return>
        void DeletePayee(Guid payeeUid);

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the void response from the API call</return>
        Task DeletePayeeAsync(Guid payeeUid);

        /// <summary>
        /// Delete a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the void response from the API call</return>
        void DeletePayeeAccount(Guid payeeUid, Guid accountUid);

        /// <summary>
        /// Delete a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the void response from the API call</return>
        Task DeletePayeeAccountAsync(Guid payeeUid, Guid accountUid);

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.Payments response from the API call</return>
        Payments ListPaymentsForPayeeAccount(Guid payeeUid, Guid accountUid, DateTime since);

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.Payments response from the API call</return>
        Task<Payments> ListPaymentsForPayeeAccountAsync(Guid payeeUid, Guid accountUid, DateTime since);

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic GetServePayeeImageFile(Guid payeeUid);

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> GetServePayeeImageFileAsync(Guid payeeUid);

    }
} 