using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ICardsController
    {
        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableGamblingPayments(Guid cardUid, Enabling body);

        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableGamblingPaymentsAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnablePos(Guid cardUid, Enabling body);

        /// <summary>
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnablePosAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update magstripe payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableMagStripePayment(Guid cardUid, Enabling body);

        /// <summary>
        /// Update magstripe payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableMagStripePaymentAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update currency switch payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableCurrencySwitch(Guid cardUid, CurrencyFlag body);

        /// <summary>
        /// Update currency switch payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableCurrencySwitchAsync(Guid cardUid, CurrencyFlag body);

        /// <summary>
        /// Update card lock
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableCard(Guid cardUid, Enabling body);

        /// <summary>
        /// Update card lock
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableCardAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableAtm(Guid cardUid, Enabling body);

        /// <summary>
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableAtmAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update online payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableOnlinePayments(Guid cardUid, Enabling body);

        /// <summary>
        /// Update online payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableOnlinePaymentsAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEnableMobileWallet(Guid cardUid, Enabling body);

        /// <summary>
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEnableMobileWalletAsync(Guid cardUid, Enabling body);

        /// <summary>
        /// Get all the cards for an account holder
        /// </summary>
        /// <return>Returns the Models.Cards response from the API call</return>
        Cards ListCards();

        /// <summary>
        /// Get all the cards for an account holder
        /// </summary>
        /// <return>Returns the Models.Cards response from the API call</return>
        Task<Cards> ListCardsAsync();

    }
} 