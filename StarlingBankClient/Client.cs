using System;
using StarlingBank.Controllers;
using StarlingBank.Http.Client;

namespace StarlingBank
{
    public class Client: IClientClient
    {

        /// <summary>
        /// Singleton access to Webhooks controller
        /// </summary>
        public IWebhooksController Webhooks => WebhooksController.Instance;

        /// <summary>
        /// Singleton access to Accounts controller
        /// </summary>
        public IAccountsController Accounts => AccountsController.Instance;

        /// <summary>
        /// Singleton access to Businesses controller
        /// </summary>
        public IBusinessesController Businesses => BusinessesController.Instance;

        /// <summary>
        /// Singleton access to IndividualsAndSoleTraders controller
        /// </summary>
        public IIndividualsAndSoleTradersController IndividualsAndSoleTraders => IndividualsAndSoleTradersController.Instance;

        /// <summary>
        /// Singleton access to JointAccounts controller
        /// </summary>
        public IJointAccountsController JointAccounts => JointAccountsController.Instance;

        /// <summary>
        /// Singleton access to SoleTraders controller
        /// </summary>
        public ISoleTradersController SoleTraders => SoleTradersController.Instance;

        /// <summary>
        /// Singleton access to SpendingInsights controller
        /// </summary>
        public ISpendingInsightsController SpendingInsights => SpendingInsightsController.Instance;

        /// <summary>
        /// Singleton access to AccountHolders controller
        /// </summary>
        public IAccountHoldersController AccountHolders => AccountHoldersController.Instance;

        /// <summary>
        /// Singleton access to ProfileImages controller
        /// </summary>
        public IProfileImagesController ProfileImages => ProfileImagesController.Instance;

        /// <summary>
        /// Singleton access to Addresses controller
        /// </summary>
        public IAddressesController Addresses => AddressesController.Instance;

        /// <summary>
        /// Singleton access to Cards controller
        /// </summary>
        public ICardsController Cards => CardsController.Instance;

        /// <summary>
        /// Singleton access to RecurringCardPayments controller
        /// </summary>
        public IRecurringCardPaymentsController RecurringCardPayments => RecurringCardPaymentsController.Instance;

        /// <summary>
        /// Singleton access to DirectDebitMandates controller
        /// </summary>
        public IDirectDebitMandatesController DirectDebitMandates => DirectDebitMandatesController.Instance;

        /// <summary>
        /// Singleton access to TransactionFeed controller
        /// </summary>
        public ITransactionFeedController TransactionFeed => TransactionFeedController.Instance;

        /// <summary>
        /// Singleton access to FeedRoundUp controller
        /// </summary>
        public IFeedRoundUpController FeedRoundUp => FeedRoundUpController.Instance;

        /// <summary>
        /// Singleton access to APIUserIdentities controller
        /// </summary>
        public IAPIUserIdentitiesController APIUserIdentities => APIUserIdentitiesController.Instance;

        /// <summary>
        /// Singleton access to KYC controller
        /// </summary>
        public IKYCController KYC => KYCController.Instance;

        /// <summary>
        /// Singleton access to Payments controller
        /// </summary>
        public IPaymentsController Payments => PaymentsController.Instance;

        /// <summary>
        /// Singleton access to Onboarding controller
        /// </summary>
        public IOnboardingController Onboarding => OnboardingController.Instance;

        /// <summary>
        /// Singleton access to Payees controller
        /// </summary>
        public IPayeesController Payees => PayeesController.Instance;

        /// <summary>
        /// Singleton access to SavingsGoals controller
        /// </summary>
        public ISavingsGoalsController SavingsGoals => SavingsGoalsController.Instance;

        /// <summary>
        /// Singleton access to SettleUp controller
        /// </summary>
        public ISettleUpController SettleUp => SettleUpController.Instance;

        /// <summary>
        /// Singleton access to Subscriptions controller
        /// </summary>
        public ISubscriptionsController Subscriptions => SubscriptionsController.Instance;

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHTTPClient SharedHTTPClient
        {
            get => BaseController.ClientInstance;
            set => BaseController.ClientInstance = value;
        }
        #region Constructors

        private Client()
        {

        }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public Client(Configuration.Environments environment, string oAuthAccessToken)
        {
            if (string.IsNullOrEmpty(oAuthAccessToken))
            {
                throw new ArgumentNullException(nameof(oAuthAccessToken) + " cannot be null.");
            }
            Configuration.Environment = environment;
            Configuration.OAuthAccessToken = oAuthAccessToken;
        }
        #endregion


    }
}