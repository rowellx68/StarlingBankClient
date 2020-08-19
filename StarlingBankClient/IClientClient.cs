using StarlingBank.Controllers;

// ReSharper disable UnusedMemberInSuper.Global
// ReSharper disable UnusedMember.Global

namespace StarlingBank
{
    public interface IClientClient
    {

        /// <summary>
        /// Singleton access to Webhooks controller
        /// </summary>
        IWebhooksController Webhooks { get;}

        /// <summary>
        /// Singleton access to Accounts controller
        /// </summary>
        IAccountsController Accounts { get;}

        /// <summary>
        /// Singleton access to Businesses controller
        /// </summary>
        IBusinessesController Businesses { get;}

        /// <summary>
        /// Singleton access to IndividualsAndSoleTraders controller
        /// </summary>
        IIndividualsAndSoleTradersController IndividualsAndSoleTraders { get;}

        /// <summary>
        /// Singleton access to JointAccounts controller
        /// </summary>
        IJointAccountsController JointAccounts { get;}

        /// <summary>
        /// Singleton access to SoleTraders controller
        /// </summary>
        ISoleTradersController SoleTraders { get;}

        /// <summary>
        /// Singleton access to SpendingInsights controller
        /// </summary>
        ISpendingInsightsController SpendingInsights { get;}

        /// <summary>
        /// Singleton access to AccountHolders controller
        /// </summary>
        IAccountHoldersController AccountHolders { get;}

        /// <summary>
        /// Singleton access to ProfileImages controller
        /// </summary>
        IProfileImagesController ProfileImages { get;}

        /// <summary>
        /// Singleton access to Addresses controller
        /// </summary>
        IAddressesController Addresses { get;}

        /// <summary>
        /// Singleton access to Cards controller
        /// </summary>
        ICardsController Cards { get;}

        /// <summary>
        /// Singleton access to RecurringCardPayments controller
        /// </summary>
        IRecurringCardPaymentsController RecurringCardPayments { get;}

        /// <summary>
        /// Singleton access to DirectDebitMandates controller
        /// </summary>
        IDirectDebitMandatesController DirectDebitMandates { get;}

        /// <summary>
        /// Singleton access to TransactionFeed controller
        /// </summary>
        ITransactionFeedController TransactionFeed { get;}

        /// <summary>
        /// Singleton access to FeedRoundUp controller
        /// </summary>
        IFeedRoundUpController FeedRoundUp { get;}

        /// <summary>
        /// Singleton access to APIUserIdentities controller
        /// </summary>
        IAPIUserIdentitiesController APIUserIdentities { get;}

        /// <summary>
        /// Singleton access to KYC controller
        /// </summary>
        IKYCController KYC { get;}

        /// <summary>
        /// Singleton access to Payments controller
        /// </summary>
        IPaymentsController Payments { get;}

        /// <summary>
        /// Singleton access to Onboarding controller
        /// </summary>
        IOnboardingController Onboarding { get;}

        /// <summary>
        /// Singleton access to Payees controller
        /// </summary>
        IPayeesController Payees { get;}

        /// <summary>
        /// Singleton access to SavingsGoals controller
        /// </summary>
        ISavingsGoalsController SavingsGoals { get;}

        /// <summary>
        /// Singleton access to SettleUp controller
        /// </summary>
        ISettleUpController SettleUp { get;}

        /// <summary>
        /// Singleton access to Subscriptions controller
        /// </summary>
        ISubscriptionsController Subscriptions { get;}

    }
}