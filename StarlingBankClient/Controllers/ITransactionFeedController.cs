using System;
using System.IO;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ITransactionFeedController
    {
        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: User Note</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateUserNote(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UserNoteWrapper body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: User Note</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateUserNoteAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UserNoteWrapper body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="feedItemAttachmentUid">Required parameter: Feed item attachment uid</param>
        /// <return>Returns the Stream response from the API call</return>
        Stream GetDownloadFeedItemAttachment(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Guid feedItemAttachmentUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="feedItemAttachmentUid">Required parameter: Feed item attachment uid</param>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> GetDownloadFeedItemAttachmentAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Guid feedItemAttachmentUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.Receipt response from the API call</return>
        Receipt GetReceipt(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.Receipt response from the API call</return>
        Task<Receipt> GetReceiptAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Receipt</param>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        ReceiptCreationResponse CreateOrUpdateReceipt(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Receipt body);

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Receipt</param>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        Task<ReceiptCreationResponse> CreateOrUpdateReceiptAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Receipt body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Spending category</param>
        /// <return>Returns the void response from the API call</return>
        void ChangeTransactionCategory(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UpdateSpendingCategory body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Spending category</param>
        /// <return>Returns the void response from the API call</return>
        Task ChangeTransactionCategoryAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UpdateSpendingCategory body);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        FeedItem GetFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        Task<FeedItem> GetFeedItemAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        FeedItems GetQueryFeedItems(Guid accountUid, Guid categoryUid, DateTime changesSince);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        Task<FeedItems> GetQueryFeedItemsAsync(Guid accountUid, Guid categoryUid, DateTime changesSince);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="minTransactionTimestamp">Required parameter: Minimum transaction timestamp</param>
        /// <param name="maxTransactionTimestamp">Required parameter: Maximum transaction timestamp</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        FeedItems GetQueryFeedItemsWithTransactionTimesBetween(
                Guid accountUid,
                Guid categoryUid,
                DateTime minTransactionTimestamp,
                DateTime maxTransactionTimestamp);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="minTransactionTimestamp">Required parameter: Minimum transaction timestamp</param>
        /// <param name="maxTransactionTimestamp">Required parameter: Maximum transaction timestamp</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        Task<FeedItems> GetQueryFeedItemsWithTransactionTimesBetweenAsync(
                Guid accountUid,
                Guid categoryUid,
                DateTime minTransactionTimestamp,
                DateTime maxTransactionTimestamp);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        FeedItemAttachments GetFeedItemAttachments(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        Task<FeedItemAttachments> GetFeedItemAttachmentsAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        MastercardFeedItem GetMastercardFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        Task<MastercardFeedItem> GetMastercardFeedItemAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid);

    }
} 