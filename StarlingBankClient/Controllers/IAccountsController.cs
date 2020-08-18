using System;
using System.IO;
using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IAccountsController
    {
        /// <summary>
        /// This endpoint lists an account holder's bank accounts.
        /// An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
        /// This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <return>Returns the Models.Accounts response from the API call</return>
        Accounts GetAccounts();

        /// <summary>
        /// This endpoint lists an account holder's bank accounts.
        /// An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
        /// This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <return>Returns the Models.Accounts response from the API call</return>
        Task<Accounts> GetAccountsAsync();

        /// <summary>
        /// Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        AccountStatementPeriods GetAvailablePeriods(Guid accountUid);

        /// <summary>
        /// Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        Task<AccountStatementPeriods> GetAvailablePeriodsAsync(Guid accountUid);

        /// <summary>
        /// Identifiers come in pairs:
        /// * A bank identifier, which identifies the bank
        /// * An account identifier, which identifiers the account at the bank
        /// Identifiers can be:
        /// * Sort code and account number for domestic UK payments
        /// * BIC and IBAN for international payments
        /// * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        AccountIdentifiers GetAccountIdentifiers(Guid accountUid);

        /// <summary>
        /// Identifiers come in pairs:
        /// * A bank identifier, which identifies the bank
        /// * An account identifier, which identifiers the account at the bank
        /// Identifiers can be:
        /// * Sort code and account number for domestic UK payments
        /// * BIC and IBAN for international payments
        /// * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        Task<AccountIdentifiers> GetAccountIdentifiersAsync(Guid accountUid);

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        /// * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        /// * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        /// Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        /// To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        BalanceV2 GetAccountBalance(Guid accountUid);

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        /// * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        /// * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        /// Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        /// To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        Task<BalanceV2> GetAccountBalanceAsync(Guid accountUid);

        /// <summary>
        /// Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        ConfirmationOfFundsResponse GetConfirmationOfFunds(Guid accountUid, long targetAmountInMinorUnits);

        /// <summary>
        /// Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        Task<ConfirmationOfFundsResponse> GetConfirmationOfFundsAsync(Guid accountUid, long targetAmountInMinorUnits);

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="yearMonth">Required parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        Stream GetDownloadCsvStatement(Guid accountUid, string yearMonth);

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="yearMonth">Required parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> GetDownloadCsvStatementAsync(Guid accountUid, string yearMonth);

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="start">Required parameter: Example: </param>
        /// <param name="end">Optional parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        Stream GetDownloadCsvStatementForDateRange(Guid accountUid, DateTime start, DateTime? end = null);

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="start">Required parameter: Example: </param>
        /// <param name="end">Optional parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> GetDownloadCsvStatementForDateRangeAsync(Guid accountUid, DateTime start, DateTime? end = null);

    }
} 