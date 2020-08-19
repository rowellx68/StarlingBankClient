using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface IRecurringCardPaymentsController
    {
        /// <summary>
        /// Fetch recurring card payments for an account holder
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.RecurringCardPayment response from the API call</return>
        RecurringCardPayment ListRecurringPayments(Guid accountUid);

        /// <summary>
        /// Fetch recurring card payments for an account holder
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.RecurringCardPayment response from the API call</return>
        Task<RecurringCardPayment> ListRecurringPaymentsAsync(Guid accountUid);

    }
} 