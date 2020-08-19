using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface IPaymentsController
    {
        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        PaymentOrderV2 GetPaymentOrder(Guid paymentOrderUid);

        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        Task<PaymentOrderV2> GetPaymentOrderAsync(Guid paymentOrderUid);

        /// <summary>
        /// Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Payment instruction object.</param>
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        InstructLocalPaymentResponse UpdateMakeLocalPayment(Guid accountUid, Guid categoryUid, InstructLocalPaymentRequest body);

        /// <summary>
        /// Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Payment instruction object.</param>
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        Task<InstructLocalPaymentResponse> UpdateMakeLocalPaymentAsync(Guid accountUid, Guid categoryUid, InstructLocalPaymentRequest body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        StandingOrdersResponse ListStandingOrders(Guid accountUid, Guid categoryUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        Task<StandingOrdersResponse> ListStandingOrdersAsync(Guid accountUid, Guid categoryUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Standing order creation object.</param>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        CreateStandingOrderResponse CreateStandingOrder(Guid accountUid, Guid categoryUid, CreateStandingOrderRequest body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Standing order creation object.</param>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        Task<CreateStandingOrderResponse> CreateStandingOrderAsync(Guid accountUid, Guid categoryUid, CreateStandingOrderRequest body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        StandingOrder GetStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        Task<StandingOrder> GetStandingOrderAsync(Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <param name="body">Required parameter: Standing order update request.</param>
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        UpdateStandingOrderResponse UpdateStandingOrder(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                UpdateStandingOrderRequest body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <param name="body">Required parameter: Standing order update request.</param>
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        Task<UpdateStandingOrderResponse> UpdateStandingOrderAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                UpdateStandingOrderRequest body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteCancelStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteCancelStandingOrderAsync(Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

        /// <summary>
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <param name="count">Optional parameter: Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10.</param>
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        NextPaymentDatesResponse ListNextPaymentDates(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                int? count = null);

        /// <summary>
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <param name="count">Optional parameter: Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10.</param>
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        Task<NextPaymentDatesResponse> ListNextPaymentDatesAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                int? count = null);

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        PaymentOrderPaymentsResponse GetPaymentOrderPayments(Guid paymentOrderUid);

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        Task<PaymentOrderPaymentsResponse> GetPaymentOrderPaymentsAsync(Guid paymentOrderUid);

    }
} 